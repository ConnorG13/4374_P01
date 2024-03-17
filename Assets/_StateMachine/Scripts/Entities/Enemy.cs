using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int _roomNum = 1;
    [SerializeField] private Unit _player;
    private int _playerRoom;

    public void ActivateChild(int childIndex)
    {
        GameObject currentChild = this.gameObject.transform.GetChild(childIndex).gameObject;

        currentChild.SetActive(true);

    }

    public void DeactivateChild(int childIndex)
    {
        GameObject currentChild = this.gameObject.transform.GetChild(childIndex).gameObject;

        currentChild.SetActive(false);

    }

    public void MonsterCheck()
    {
        _playerRoom = _player._roomNum;

        switch (_roomNum)
        {
            case 1:
                if (_playerRoom == 2 || _playerRoom == 3 || _playerRoom == 6)
                {
                    MonsterMove(2);
                } 
                else if (_playerRoom == 5)
                {
                    MonsterMove(5);
                }
                else
                {
                    MonsterMove(7);
                }
                break;
            case 2:
                if (_playerRoom == 1 || _playerRoom == 5)
                {
                    MonsterMove(1);
                }
                else
                {
                    MonsterMove(3);
                }
                break;
            case 3:
                if (_playerRoom == 4)
                {
                    MonsterMove(4);
                }
                else if (_playerRoom == 6)
                {
                    MonsterMove(6);
                }
                else if (_playerRoom == 1 || _playerRoom == 2)
                {
                    MonsterMove(2);
                }
                else
                {
                    MonsterMove(8);
                }
                break;
            case 4:
                if (_playerRoom == 1 || _playerRoom == 5)
                {
                    MonsterMove(7);
                }
                else
                {
                    MonsterMove(3);
                }
                break;
            case 5:
                if (_playerRoom == 1 || _playerRoom == 2)
                {
                    MonsterMove(1);
                }
                else
                {
                    MonsterMove(8);
                }
                break;
            case 6:
                if (_playerRoom == 1 || _playerRoom == 5)
                {
                    MonsterMove(8);
                }
                else
                {
                    MonsterMove(3);
                }
                break;
            case 7:
                if (_playerRoom == 1 || _playerRoom == 2 || _playerRoom == 5)
                {
                    MonsterMove(1);
                }
                else
                {
                    MonsterMove(4);
                }
                break;
            case 8:
                if (_playerRoom == 1 || _playerRoom == 5)
                {
                    MonsterMove(5);
                }
                else
                {
                    MonsterMove(3);
                }
                break;
        }
    }

    public void MonsterMove(int roomNumber)
    {
        _roomNum = roomNumber;

        switch (_roomNum)
        {
            case 1:
                ActivateChild(0);
                DeactivateChild(1);
                DeactivateChild(4);
                DeactivateChild(6);
                break;
            case 2:
                ActivateChild(1);
                DeactivateChild(0);
                DeactivateChild(2);
                break;
            case 3:
                ActivateChild(2);
                DeactivateChild(1);
                DeactivateChild(3);
                DeactivateChild(5);
                DeactivateChild(7);
                break;
            case 4:
                ActivateChild(3);
                DeactivateChild(2);
                DeactivateChild(6);
                break;
            case 5:
                ActivateChild(4);
                DeactivateChild(0);
                DeactivateChild(7);
                break;
            case 6:
                ActivateChild(5);
                DeactivateChild(2);
                break;
            case 7:
                ActivateChild(6);
                DeactivateChild(0);
                DeactivateChild(3);
                break;
            case 8:
                ActivateChild(7);
                DeactivateChild(4);
                DeactivateChild(2);
                DeactivateChild(5);
                break;
        }

    }
}
