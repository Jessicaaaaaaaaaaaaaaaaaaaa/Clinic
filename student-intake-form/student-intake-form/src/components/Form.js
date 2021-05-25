import React, { Component} from 'react';

class Form extends Component {
constructor(props){
super(props)
this.state={
patientname:'',
age:0,
address:'',
comments:'',
doctor:0
}
}

handlePatientName = (event) =>{
this.setState({
patientname: event.target.value
})
}

handleAge = (event) => {
this.setState({
age: event.target.value
})
}

handleAddress = (event) => {
this.setState({
address: event.target.value
})
}

handleComments = (event) =>{
this.setState({
comments: event.target.comments
})
}

handleDoctor = (event) => {
this.setState({
doctor: event.target.value
})
}

render(){
return(
<form>
<div>
<label>Patient's Name:</label>
<input type="text" value={this.state.patientname} onChange={this.handlePatientName}></input>
</div>
<div>
<label>Age:</label>
<input type="number" value={this.state.age} onChange={this.handleAge}></input>
</div>
<div>
<label>Address:</label>
<input type="text" value={this.state.address} onChange={this.handleAddress}></input>
</div>
<div>
<label>Select Doctor:</label>
<select value={this.state.doctor} onChange={this.handleDoctor}>
<option value="1">Dr. Mary</option>
<option value="2">Dr. Smith</option>
<option value="3">Dr. John</option>
</select>
</div>
<div>
<label>Doctor Comments:</label>
<textarea value={this.state.comments} onChange={this.handleComments}></textarea>
</div>
<div>
    <button></button>
</div>
</form>
)
}
}

export default Form;