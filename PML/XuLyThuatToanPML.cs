using Accord.Collections;
using Accord.MachineLearning.DecisionTrees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Accord.MachineLearning.DecisionTrees.Learning;

//PredictionModelLayer
namespace PML
{
    public class XuLyThuatToanPML
    {
        private DecisionTree dtree;
        public int[][] trainingInputs;
        public int[] trainingOutputs;

        public void TrainModel(List<InventoryData> inventoryData)
        {
            trainingInputs = inventoryData.Select(d => new int[]
            {
                   d.QuantitySold,
                   d.StockLevel,
                  (int)Math.Round(d.Price / 100),
            }).ToArray();

            trainingOutputs = inventoryData.Select(d => d.NeedRestock ? 1 : 0).ToArray();

            var id3Learning = new ID3Learning();

            dtree = id3Learning.Learn(trainingInputs, trainingOutputs);
        }
        public int Predict(InventoryData newProduct)
        {
            if (dtree == null)
            {
                throw new InvalidOperationException("Mô hình chưa được huấn luyện.");
            }

            int[] input = new int[]
            {
                newProduct.QuantitySold,
                newProduct.StockLevel,
                (int)Math.Round(newProduct.Price / 100)
            };

            return dtree.Decide(input); 
        }
    }
}
