using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UnityGridStyle : MonoBehaviour
{
    protected int cellWidth { get; set; }
    protected int cellHeight { get; set; }
    protected int maxHorizontal { get; set; }
    protected int maxVertical { get; set; }

    protected abstract void sortCell();
}
