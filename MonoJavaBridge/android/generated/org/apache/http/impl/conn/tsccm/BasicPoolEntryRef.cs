namespace org.apache.http.impl.conn.tsccm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicPoolEntryRef : java.lang.@ref.WeakReference
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BasicPoolEntryRef(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::org.apache.http.conn.routing.HttpRoute Route
		{
			get
			{
				return getRoute();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRoute33126;
		public virtual global::org.apache.http.conn.routing.HttpRoute getRoute()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.HttpRoute>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.conn.tsccm.BasicPoolEntryRef.staticClass, global::org.apache.http.impl.conn.tsccm.BasicPoolEntryRef._getRoute33126)) as org.apache.http.conn.routing.HttpRoute;
		}
		internal static global::MonoJavaBridge.MethodId _BasicPoolEntryRef33127;
		public BasicPoolEntryRef(org.apache.http.impl.conn.tsccm.BasicPoolEntry arg0, java.lang.@ref.ReferenceQueue arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.tsccm.BasicPoolEntryRef.staticClass, global::org.apache.http.impl.conn.tsccm.BasicPoolEntryRef._BasicPoolEntryRef33127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static BasicPoolEntryRef()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.tsccm.BasicPoolEntryRef.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/tsccm/BasicPoolEntryRef"));
			global::org.apache.http.impl.conn.tsccm.BasicPoolEntryRef._getRoute33126 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.BasicPoolEntryRef.staticClass, "getRoute", "()Lorg/apache/http/conn/routing/HttpRoute;");
			global::org.apache.http.impl.conn.tsccm.BasicPoolEntryRef._BasicPoolEntryRef33127 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.BasicPoolEntryRef.staticClass, "<init>", "(Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;Ljava/lang/ref/ReferenceQueue;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
