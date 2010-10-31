namespace org.apache.http.conn.scheme
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Scheme : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Scheme(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.conn.scheme.Scheme.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::org.apache.http.conn.scheme.Scheme._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.conn.scheme.Scheme.staticClass, "toString", "()Ljava/lang/String;", ref global::org.apache.http.conn.scheme.Scheme._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.conn.scheme.Scheme.staticClass, "hashCode", "()I", ref global::org.apache.http.conn.scheme.Scheme._m2);
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.conn.scheme.Scheme.staticClass, "getName", "()Ljava/lang/String;", ref global::org.apache.http.conn.scheme.Scheme._m3) as java.lang.String;
		}
		public new int DefaultPort
		{
			get
			{
				return getDefaultPort();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public int getDefaultPort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.conn.scheme.Scheme.staticClass, "getDefaultPort", "()I", ref global::org.apache.http.conn.scheme.Scheme._m4);
		}
		public new global::org.apache.http.conn.scheme.SocketFactory SocketFactory
		{
			get
			{
				return getSocketFactory();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public global::org.apache.http.conn.scheme.SocketFactory getSocketFactory()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.conn.scheme.SocketFactory>(this, global::org.apache.http.conn.scheme.Scheme.staticClass, "getSocketFactory", "()Lorg/apache/http/conn/scheme/SocketFactory;", ref global::org.apache.http.conn.scheme.Scheme._m5) as org.apache.http.conn.scheme.SocketFactory;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public bool isLayered()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.conn.scheme.Scheme.staticClass, "isLayered", "()Z", ref global::org.apache.http.conn.scheme.Scheme._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public int resolvePort(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.conn.scheme.Scheme.staticClass, "resolvePort", "(I)I", ref global::org.apache.http.conn.scheme.Scheme._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public Scheme(java.lang.String arg0, org.apache.http.conn.scheme.SocketFactory arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.scheme.Scheme._m8.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.scheme.Scheme._m8 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.Scheme.staticClass, "<init>", "(Ljava/lang/String;Lorg/apache/http/conn/scheme/SocketFactory;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.scheme.Scheme.staticClass, global::org.apache.http.conn.scheme.Scheme._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static Scheme()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.scheme.Scheme.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/scheme/Scheme"));
		}
	}
}
