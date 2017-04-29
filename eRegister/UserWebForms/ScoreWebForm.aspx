<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/ProfileMasterPage.Master" AutoEventWireup="true" CodeBehind="ScoreWebForm.aspx.cs" Inherits="eRegister.UserWebForms.ScoreWebForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="scores" runat="server">
    <div class="col-md-9 col-lg-9 col-sm-12 col-xs-12">
				
				<div class="tabbable boxed parentTabs">
				    <ul class="nav nav-tabs">
				        <li class="active"><a href="#set1">Български език и литература</a>
				        </li>
				        <li><a href="#set2">Математика</a>
				        </li>
				        <li><a href="#set3">Физика</a>
				        </li>
				    </ul>
				    <div class="tab-content">
				        <div class="tab-pane fade active in" id="set1">
				            <div class="tabbable score-info">
				            	<p>
				            		<label>Учител: </label> Иван Иванов
				            	</p>

				            	<p>
				            		<label>Оценки:</label>
				            	</p>
				                <ul class="nav nav-tabs">
				                    <li class="active"><a href="#sub11">Първи срок</a>
				                    </li>
				                    <li><a href="#sub12">Втори срок</a>
				                    </li>
				                </ul>
				                <div class="tab-content">
				                    <div class="tab-pane fade active in" id="sub11">
				                        <table class="table">
										    <thead>
										      <tr>
										        <th>#</th>
										        <th>Форма на контрол</th>
										        <th>Оценка</th>
										        <th>Дата</th>
										      </tr>
										    </thead>
										    <tbody>
										      <tr>
										        <td>1</td>
										        <td>Текуща оценка</td>
										        <td>Много добър (5)</td>
										        <td>29.04.2017</td>
										      </tr>
										      <tr>
										        <td>2</td>
										        <td>Текуща оценка</td>
										        <td>Добър (4)</td>
										        <td>29.04.2017</td>
										      </tr>
										      <tr>
										        <td>3</td>
										        <td>Текуща оценка</td>
										        <td>Много добър (5)</td>
										        <td>29.04.2017</td>
										      </tr>
										    </tbody>
										</table>
										 <label>Среден успех: </label> <span id="av-score">4,66</span>
				                    </div>
				                    <div class="tab-pane fade" id="sub12">
				                       <table class="table">
										    <thead>
										      <tr>
										        <th>#</th>
										        <th>Форма на контрол</th>
										        <th>Оценка</th>
										        <th>Дата</th>
										      </tr>
										    </thead>
										    <tbody>
										      <tr>
										        <td>1</td>
										        <td>Изпит</td>
										        <td>Много добър (5)</td>
										        <td>29.04.2017</td>
										      </tr>
										      <tr>
										        <td>2</td>
										        <td>Текуща оценка</td>
										        <td>Добър (4)</td>
										        <td>29.04.2017</td>
										      </tr>
										      <tr>
										        <td>3</td>
										        <td>Изпит</td>
										        <td>Много добър (5)</td>
										        <td>29.04.2017</td>
										      </tr>

										    </tbody>
										  </table>
										  <label>Среден успех: </label> <span id="av-score">4,66</span>
				                    </div>
				                </div>
				            </div>
				        </div>
				        <div class="tab-pane fade" id="set2">
				            <div class="tabbable score-info">
				            	<p>
				            		<label>Учител: </label> Тодор Атанасов
				            	</p>

				            	<p>
				            		<label>Оценки:</label>
				            	</p>
				                <ul class="nav nav-tabs">
				                    <li class="active"><a href="#sub21">Първи срок</a>
				                    </li>
				                    <li><a href="#sub22">Втори срок</a>
				                    </li>
				                </ul>
				                <div class="tab-content">
				                    <div class="tab-pane fade active in" id="sub21">
				                        <table class="table">
										    <thead>
										      <tr>
										        <th>#</th>
										        <th>Форма на контрол</th>
										        <th>Оценка</th>
										        <th>Дата</th>
										      </tr>
										    </thead>
										    <tbody>
										      <tr>
										        <td>1</td>
										        <td>Текуща оценка</td>
										        <td>Много добър (5)</td>
										        <td>29.04.2017</td>
										      </tr>
										      <tr>
										        <td>2</td>
										        <td>Текуща оценка</td>
										        <td>Добър (4)</td>
										        <td>29.04.2017</td>
										      </tr>
										      <tr>
										        <td>3</td>
										        <td>Текуща оценка</td>
										        <td>Много добър (5)</td>
										        <td>29.04.2017</td>
										      </tr>
										    </tbody>
										</table>
										<label>Среден успех: </label> <span id="av-score">4,66</span>
				                    </div>
				                    <div class="tab-pane fade" id="sub22">
				                        <table class="table">
										    <thead>
										      <tr>
										        <th>#</th>
										        <th>Форма на контрол</th>
										        <th>Оценка</th>
										        <th>Дата</th>
										      </tr>
										    </thead>
										    <tbody>
										      <tr>
										        <td>1</td>
										        <td>Изпит</td>
										        <td>Много добър (5)</td>
										        <td>29.04.2017</td>
										      </tr>
										      <tr>
										        <td>2</td>
										        <td>Текуща оценка</td>
										        <td>Добър (4)</td>
										        <td>29.04.2017</td>
										      </tr>
										      <tr>
										        <td>3</td>
										        <td>Изпит</td>
										        <td>Много добър (5)</td>
										        <td>29.04.2017</td>
										      </tr>

										    </tbody>
										  </table>
										  <label>Среден успех: </label> <span id="av-score">4,66</span>
				                    </div>
				                </div>
				            </div>
				        </div>
				        <div class="tab-pane fade" id="set3">
				            <div class="tabbable score-info">
				            	<p>
				            		<label>Учител: </label> Иван Стефанов
				            	</p>

				            	<p>
				            		<label>Оценки:</label>
				            	</p>
				                <ul class="nav nav-tabs">
				                    <li class="active"><a href="#sub31">Първи срок</a>
				                    </li>
				                    <li><a href="#sub32">Втори срок</a>
				                    </li>
				                </ul>
				                <div class="tab-content">
				                    <div class="tab-pane fade active in" id="sub31">
				                       <table class="table">
										    <thead>
										      <tr>
										        <th>#</th>
										        <th>Форма на контрол</th>
										        <th>Оценка</th>
										        <th>Дата</th>
										      </tr>
										    </thead>
										    <tbody>
										      <tr>
										        <td>1</td>
										        <td>Текуща оценка</td>
										        <td>Много добър (5)</td>
										        <td>29.04.2017</td>
										      </tr>
										      <tr>
										        <td>2</td>
										        <td>Текуща оценка</td>
										        <td>Добър (4)</td>
										        <td>29.04.2017</td>
										      </tr>
										      <tr>
										        <td>3</td>
										        <td>Текуща оценка</td>
										        <td>Много добър (5)</td>
										        <td>29.04.2017</td>
										      </tr>
										    </tbody>
										</table>
										<label>Среден успех: </label> <span id="av-score">4,66</span>	
				                    </div>
				                    <div class="tab-pane fade" id="sub32">
				                        <table class="table">
										    <thead>
										      <tr>
										        <th>#</th>
										        <th>Форма на контрол</th>
										        <th>Оценка</th>
										        <th>Дата</th>
										      </tr>
										    </thead>
										    <tbody>
										      <tr>
										        <td>1</td>
										        <td>Изпит</td>
										        <td>Много добър (5)</td>
										        <td>29.04.2017</td>
										      </tr>
										      <tr>
										        <td>2</td>
										        <td>Текуща оценка</td>
										        <td>Добър (4)</td>
										        <td>29.04.2017</td>
										      </tr>
										      <tr>
										        <td>3</td>
										        <td>Изпит</td>
										        <td>Много добър (5)</td>
										        <td>29.04.2017</td>
										      </tr>

										    </tbody>
										  </table>
										  <label>Среден успех: </label> <span id="av-score">4,66</span>
				                    </div>
				                </div>
				            </div>
				        </div>
				    </div>
				</div>
			</div>
</asp:Content>
