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
		internal static global::MonoJavaBridge.MethodId _equals32183;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.scheme.Scheme._equals32183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.scheme.Scheme.staticClass, global::org.apache.http.conn.scheme.Scheme._equals32183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString32184;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.Scheme._toString32184)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.Scheme.staticClass, global::org.apache.http.conn.scheme.Scheme._toString32184)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode32185;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.scheme.Scheme._hashCode32185);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.scheme.Scheme.staticClass, global::org.apache.http.conn.scheme.Scheme._hashCode32185);
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName32186;
		public global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.Scheme._getName32186)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.Scheme.staticClass, global::org.apache.http.conn.scheme.Scheme._getName32186)) as java.lang.String;
		}
		public new int DefaultPort
		{
			get
			{
				return getDefaultPort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultPort32187;
		public int getDefaultPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.scheme.Scheme._getDefaultPort32187);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.scheme.Scheme.staticClass, global::org.apache.http.conn.scheme.Scheme._getDefaultPort32187);
		}
		public new global::org.apache.http.conn.scheme.SocketFactory SocketFactory
		{
			get
			{
				return getSocketFactory();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSocketFactory32188;
		public global::org.apache.http.conn.scheme.SocketFactory getSocketFactory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.scheme.SocketFactory>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.Scheme._getSocketFactory32188)) as org.apache.http.conn.scheme.SocketFactory;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.scheme.SocketFactory>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.Scheme.staticClass, global::org.apache.http.conn.scheme.Scheme._getSocketFactory32188)) as org.apache.http.conn.scheme.SocketFactory;
		}
		internal static global::MonoJavaBridge.MethodId _isLayered32189;
		public bool isLayered() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.scheme.Scheme._isLayered32189);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.scheme.Scheme.staticClass, global::org.apache.http.conn.scheme.Scheme._isLayered32189);
		}
		internal static global::MonoJavaBridge.MethodId _resolvePort32190;
		public int resolvePort(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.scheme.Scheme._resolvePort32190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.scheme.Scheme.staticClass, global::org.apache.http.conn.scheme.Scheme._resolvePort32190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Scheme32191;
		public Scheme(java.lang.String arg0, org.apache.http.conn.scheme.SocketFactory arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.scheme.Scheme.staticClass, global::org.apache.http.conn.scheme.Scheme._Scheme32191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.scheme.Scheme.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/scheme/Scheme"));
			global::org.apache.http.conn.scheme.Scheme._equals32183 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.Scheme.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::org.apache.http.conn.scheme.Scheme._toString32184 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.Scheme.staticClass, "toString", "()Ljava/lang/String;");
			global::org.apache.http.conn.scheme.Scheme._hashCode32185 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.Scheme.staticClass, "hashCode", "()I");
			global::org.apache.http.conn.scheme.Scheme._getName32186 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.Scheme.staticClass, "getName", "()Ljava/lang/String;");
			global::org.apache.http.conn.scheme.Scheme._getDefaultPort32187 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.Scheme.staticClass, "getDefaultPort", "()I");
			global::org.apache.http.conn.scheme.Scheme._getSocketFactory32188 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.Scheme.staticClass, "getSocketFactory", "()Lorg/apache/http/conn/scheme/SocketFactory;");
			global::org.apache.http.conn.scheme.Scheme._isLayered32189 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.Scheme.staticClass, "isLayered", "()Z");
			global::org.apache.http.conn.scheme.Scheme._resolvePort32190 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.Scheme.staticClass, "resolvePort", "(I)I");
			global::org.apache.http.conn.scheme.Scheme._Scheme32191 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.Scheme.staticClass, "<init>", "(Ljava/lang/String;Lorg/apache/http/conn/scheme/SocketFactory;I)V");
		}
	}
}
