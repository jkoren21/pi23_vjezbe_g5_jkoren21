using Evaluation_Manager.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation_Manager.Models {
    public class Student : Person {
        public int Grade { get; set; }
    }

    public List<Evaluation> GetEvaluations() {
        return EvaluationRepository.GetEvaluations(this);
    }
    public int CalculateTotalPoints() {
        int totalPoints = 0;
        foreach(var evaluation in GetEvaluations()) {
            totalPoints += evaluation.Points;
        }
        return totalPoints;
    }

    public bool HasSignature() {
        bool hasSignature = true;
        if(IsEvaluationComplete() == true) {
            foreach(var evaluation in GetEvaluations()) {
                if(evaluation.IsSufficient)
            }
        }
    }
   
        
        
    
}
