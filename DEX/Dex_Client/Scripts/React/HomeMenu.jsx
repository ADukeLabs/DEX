
class CompanyList extends React.Component(props) {
    listItems = this.props.data;
    render() {
        return (
            listItems.map((c) =>
                <div className="col-xs-10 col-xs-offset-2 col-sm-6 col-sm-offset-4">
                    <button type="button" className="btn btn-primary">c.Name</button>
                </div>
            )   
        );
    }
}


class CityButton extends React.Component {
    data = [{ "Name": "Datacom" }];

    constructor() {
        this.state = {active: false}
    }
     
    activeButton() {
        this.setState = ({ active: !this.active });
    }

    render() {
        return (
            <div className="city-div">
                <button className='city-button btn btn-primary btn-block' type="button" onClick={activeButton}>Wellington, New Zealand</button>
                if(this.state.active == true)
                {
                    <CompanyList data=data/>
                }
            </div>
        );
    }
}                                   


class Menu extends React.Component {
    render() {
        return (
            <CityButton />
        );
    }
}


class App extends React.Component {
    render() {
        return (
            <div>
                <Menu />
            </div>    
        );
    }
}

ReactDOM.render(
    <App/>,
    document.getElementById("app")
);