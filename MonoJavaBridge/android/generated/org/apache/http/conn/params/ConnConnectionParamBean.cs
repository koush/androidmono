namespace org.apache.http.conn.@params
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ConnConnectionParamBean : org.apache.http.@params.HttpAbstractParamBean
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ConnConnectionParamBean(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new int MaxStatusLineGarbage
		{
			set
			{
				setMaxStatusLineGarbage(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setMaxStatusLineGarbage32174;
		public virtual void setMaxStatusLineGarbage(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.@params.ConnConnectionParamBean.staticClass, global::org.apache.http.conn.@params.ConnConnectionParamBean._setMaxStatusLineGarbage32174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ConnConnectionParamBean32175;
		public ConnConnectionParamBean(org.apache.http.@params.HttpParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.@params.ConnConnectionParamBean.staticClass, global::org.apache.http.conn.@params.ConnConnectionParamBean._ConnConnectionParamBean32175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ConnConnectionParamBean()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.@params.ConnConnectionParamBean.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/params/ConnConnectionParamBean"));
			global::org.apache.http.conn.@params.ConnConnectionParamBean._setMaxStatusLineGarbage32174 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.@params.ConnConnectionParamBean.staticClass, "setMaxStatusLineGarbage", "(I)V");
			global::org.apache.http.conn.@params.ConnConnectionParamBean._ConnConnectionParamBean32175 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.@params.ConnConnectionParamBean.staticClass, "<init>", "(Lorg/apache/http/params/HttpParams;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
