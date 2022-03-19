using UnityEngine.UI;
using UnutyEngine.SceneManagement;
//переменные - что-то хранят: "текст", 5656, True/False, GameObject(игровой объект)
public int hp = 10;
string name = "Vasya_Voin2015";
public GameObject player; //переменная, внутри которой лежит игровой объект - игрок
int playerMass;

void Start() {

}
void Update() {
    //если
    if (hp <= 0){
        //то 
        Debug.Log("Игрок" + name + " умер");
        Destroy(gameObject);
    } else {
        //иначе
        Debug.Log("Игрок еще жив!");
    }
}
void OnTriggerEnter(Collider other){
    if (other.tag == "Player") {
        Debug.Log("кто-то зашел в триггер!");
        hp = hp - 1;
        hp -= 1;
    }
    
}
void OnTriggerStay(Collider other){
    //10 -> 20
    playeMass = playerMass * 2;
    player.GetComponent<RigidBody>().mass = 4;
    
    //gameObject - текущий игровой объект
    //GameObject - тип данных для переменной, такой-же как и int sting и тд

    MyText = Int32.Parse(TextCoin.GetComponent<Text>().text); //получаем значение из интерфейса
    MyText = MyText + 1; //Прибавляем к этому значению число
    TextCoin.GetComponent<Text>().text = MyText + ""; //Новое число записываем обратно в интерфейс
}
void OnTriggerExit(Collider other){
    //SceneManager.LoadScene("scene2");
    StartCoroutine(LoadYourAsyncScene());
}


IEnumerator LoadYourAsyncScene()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Scene2");
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }

