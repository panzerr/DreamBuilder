using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BlockFacotry : MonoBehaviour {

    [SerializeField]
    protected GameObject wallPrefab;
    protected List<GameObject> walls;
    
    [SerializeField]
    protected GameObject monsterPrefab;
    protected List<GameObject> monsters;

    [SerializeField]
    protected GameObject toolPrefab;
    protected List<GameObject> tools;


    public static BlockFacotry instance;

    public static BlockFacotry Instance
    {
        get
        { return instance; }
    }

	// Use this for initialization
	void Start () {
        if (instance == null)
        {
            instance = this;
            GameObject tmp;
            // les murs
            walls = new List<GameObject>();
            int i;
            for (i = 0; i < 10; i++)
            {
                tmp = Instantiate(wallPrefab);
                tmp.transform.SetParent(this.transform);
                tmp.SetActive(false);
                walls.Add(tmp);
            }
            // les monstres
            monsters = new List<GameObject>();
            for (i = 0; i < 10; i++)
            {
                tmp = Instantiate(monsterPrefab);
                tmp.transform.SetParent(this.transform);
                tmp.SetActive(false);
                monsters.Add(tmp);
            }
            // les outils
            tools = new List<GameObject>();
            for (i = 0; i < 10; i++)
            {
                tmp = Instantiate(toolPrefab);
                tmp.transform.SetParent(this.transform);
                tmp.SetActive(false);
                tools.Add(tmp);
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    /* renvoie un mur non active*/
    public GameObject RequestWall()
    {
        GameObject ret;
        ret = walls[walls.Count - 1];
        walls.RemoveAt(walls.Count - 1);
        return ret;
    }
    
    public void GiveWall(GameObject wall)
    {
        wall.transform.SetParent(this.transform);
        wall.SetActive(false);
        walls.Add(wall);
    }

    public GameObject RequestMonster()
    {
        GameObject ret;
        ret = monsters[monsters.Count - 1];
        monsters.RemoveAt(monsters.Count - 1);
        return ret;
    }

    public void GiveMonster(GameObject monster)
    {
        monster.transform.SetParent(this.transform);
        monster.SetActive(false); 
        monsters.Add(monster);
    }

    public GameObject RequestTool()
    {
        GameObject ret;
        ret = tools[tools.Count - 1];
        tools.RemoveAt(tools.Count - 1);
        return ret;
    }

    public void GiveTool(GameObject tool)
    {
        tool.transform.SetParent(this.transform);
        tool.SetActive(false);
        tools.Add(tool);
    }



}

