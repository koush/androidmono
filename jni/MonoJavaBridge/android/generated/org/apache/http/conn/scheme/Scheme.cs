namespace org.apache.http.conn.scheme
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Scheme : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Scheme()
		{
			InitJNI();
		}
		internal Scheme(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals25585;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.scheme.Scheme._equals25585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.scheme.Scheme.staticClass, global::org.apache.http.conn.scheme.Scheme._equals25585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString25586;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.Scheme._toString25586)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.Scheme.staticClass, global::org.apache.http.conn.scheme.Scheme._toString25586)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25587;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.scheme.Scheme._hashCode25587);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.scheme.Scheme.staticClass, global::org.apache.http.conn.scheme.Scheme._hashCode25587);
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName25588;
		public global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.Scheme._getName25588)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.Scheme.staticClass, global::org.apache.http.conn.scheme.Scheme._getName25588)) as java.lang.String;
		}
		public new int DefaultPort
		{
			get
			{
				return getDefaultPort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultPort25589;
		public int getDefaultPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.scheme.Scheme._getDefaultPort25589);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.scheme.Scheme.staticClass, global::org.apache.http.conn.scheme.Scheme._getDefaultPort25589);
		}
		public new global::org.apache.http.conn.scheme.SocketFactory SocketFactory
		{
			get
			{
				return getSocketFactory();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSocketFactory25590;
		public global::org.apache.http.conn.scheme.SocketFactory getSocketFactory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.scheme.SocketFactory>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.Scheme._getSocketFactory25590)) as org.apache.http.conn.scheme.SocketFactory;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.scheme.SocketFactory>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.Scheme.staticClass, global::org.apache.http.conn.scheme.Scheme._getSocketFactory25590)) as org.apache.http.conn.scheme.SocketFactory;
		}
		internal static global::MonoJavaBridge.MethodId _isLayered25591;
		public bool isLayered() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.scheme.Scheme._isLayered25591);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.scheme.Scheme.staticClass, global::org.apache.http.conn.scheme.Scheme._isLayered25591);
		}
		internal static global::MonoJavaBridge.MethodId _resolvePort25592;
		public int resolvePort(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.scheme.Scheme._resolvePort25592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.scheme.Scheme.staticClass, global::org.apache.http.conn.scheme.Scheme._resolvePort25592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Scheme25593;
		public Scheme(java.lang.String arg0, org.apache.http.conn.scheme.SocketFactory arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.scheme.Scheme.staticClass, global::org.apache.http.conn.scheme.Scheme._Scheme25593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.scheme.Scheme.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/scheme/Scheme"));
			global::org.apache.http.conn.scheme.Scheme._equals25585 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.Scheme.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::org.apache.http.conn.scheme.Scheme._toString25586 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.Scheme.staticClass, "toString", "()Ljava/lang/String;");
			global::org.apache.http.conn.scheme.Scheme._hashCode25587 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.Scheme.staticClass, "hashCode", "()I");
			global::org.apache.http.conn.scheme.Scheme._getName25588 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.Scheme.staticClass, "getName", "()Ljava/lang/String;");
			global::org.apache.http.conn.scheme.Scheme._getDefaultPort25589 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.Scheme.staticClass, "getDefaultPort", "()I");
			global::org.apache.http.conn.scheme.Scheme._getSocketFactory25590 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.Scheme.staticClass, "getSocketFactory", "()Lorg/apache/http/conn/scheme/SocketFactory;");
			global::org.apache.http.conn.scheme.Scheme._isLayered25591 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.Scheme.staticClass, "isLayered", "()Z");
			global::org.apache.http.conn.scheme.Scheme._resolvePort25592 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.Scheme.staticClass, "resolvePort", "(I)I");
			global::org.apache.http.conn.scheme.Scheme._Scheme25593 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.Scheme.staticClass, "<init>", "(Ljava/lang/String;Lorg/apache/http/conn/scheme/SocketFactory;I)V");
		}
	}
}
