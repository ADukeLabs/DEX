function Company(data) {
    this.Id = JSON.parse(data.Id);
    this.Name = data.Name;
    this.Address = data.Address;
    this.City = data.City;
    this.Contacts = data.Contacts;
}