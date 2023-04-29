using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGenerator : MonoBehaviour
{
    [SerializeField]
    private GameObject _blockPrefab;
    [SerializeField]
    private GameObject _doubleBlockPrefab;
    [SerializeField]
    private List<Transform> _blockPositions;

    private void Start()
    {
        foreach (var position in _blockPositions)
        {
            var rnd = Random.Range(0, 2);

            if (rnd == 0)
            {
                var block = Instantiate(_blockPrefab, position.position, Quaternion.identity);
            }
            else
            {
                var block = Instantiate(_doubleBlockPrefab, position.position, Quaternion.identity);
            }
        }
    }
}
