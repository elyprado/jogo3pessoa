using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleNPC : MonoBehaviour{
    //ponto de destino
    private Vector3 target;
    //velocidade
    private float speed = 10.0F;
    void Start() {
        //inicia para nova direção
        novaDirecao();
    }
    void novaDirecao() {
        target = new Vector3(Random.Range(-100, 100), 0, Random.Range(-100, 100));
        transform.rotation = Quaternion.LookRotation(target);
    }
    void Update(){
         //move NPC
        float step =  speed * Time.deltaTime; 
        transform.position = Vector3.MoveTowards(transform.position, target, step);
        //se chegar no target vai pra nova direção
        if (transform.position == target) {
            novaDirecao();
        }
    }
    void OnCollisionEnter(Collision collision) {
        novaDirecao();
    }

}
