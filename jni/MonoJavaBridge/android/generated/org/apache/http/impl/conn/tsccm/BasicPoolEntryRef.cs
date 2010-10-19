namespace org.apache.http.impl.conn.tsccm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicPoolEntryRef : java.lang.@ref.WeakReference
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BasicPoolEntryRef()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getRoute26383;
		public virtual global::org.apache.http.conn.routing.HttpRoute getRoute() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.BasicPoolEntryRef._getRoute26383)) as org.apache.http.conn.routing.HttpRoute;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.BasicPoolEntryRef.staticClass, global::org.apache.http.impl.conn.tsccm.BasicPoolEntryRef._getRoute26383)) as org.apache.http.conn.routing.HttpRoute;
		}
		internal static global::MonoJavaBridge.MethodId _BasicPoolEntryRef26384;
		public BasicPoolEntryRef(org.apache.http.impl.conn.tsccm.BasicPoolEntry arg0, java.lang.@ref.ReferenceQueue arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.tsccm.BasicPoolEntryRef.staticClass, global::org.apache.http.impl.conn.tsccm.BasicPoolEntryRef._BasicPoolEntryRef26384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.tsccm.BasicPoolEntryRef.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/tsccm/BasicPoolEntryRef"));
			global::org.apache.http.impl.conn.tsccm.BasicPoolEntryRef._getRoute26383 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.BasicPoolEntryRef.staticClass, "getRoute", "()Lorg/apache/http/conn/routing/HttpRoute;");
			global::org.apache.http.impl.conn.tsccm.BasicPoolEntryRef._BasicPoolEntryRef26384 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.BasicPoolEntryRef.staticClass, "<init>", "(Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;Ljava/lang/@ref/ReferenceQueue;)V");
		}
	}
}
