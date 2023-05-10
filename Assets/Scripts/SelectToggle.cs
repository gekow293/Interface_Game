using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class SelectToggle : MonoBehaviour
    {
        public List<Renderer> GetRenderers()
        {
            return Renderers;
        }

        public Material GetCurrentMaterial()
        {
            return Material;
        }

        public void SetCurrentMaterial(Material material)
        {
            Material = material;
        }

        public Material Material;

        private List<Renderer> Renderers = new List<Renderer>();
    }
}
