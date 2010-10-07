namespace org.apache.http.conn.scheme
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class Scheme : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static Scheme()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::org.apache.http.conn.scheme.Scheme), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::org.apache.http.conn.scheme.Scheme(@__env);
			}
		}
		internal Scheme(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals14485;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.apache.http.conn.scheme.Scheme._equals14485, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.apache.http.conn.scheme.Scheme.staticClass, global::org.apache.http.conn.scheme.Scheme._equals14485, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString14486;
		public sealed override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.conn.scheme.Scheme._toString14486));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.conn.scheme.Scheme.staticClass, global::org.apache.http.conn.scheme.Scheme._toString14486));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode14487;
		public sealed override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::org.apache.http.conn.scheme.Scheme._hashCode14487);
			else
				return @__env.CallNonVirtualIntMethod(this, global::org.apache.http.conn.scheme.Scheme.staticClass, global::org.apache.http.conn.scheme.Scheme._hashCode14487);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getName14488;
		public global::java.lang.String getName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.conn.scheme.Scheme._getName14488));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.conn.scheme.Scheme.staticClass, global::org.apache.http.conn.scheme.Scheme._getName14488));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultPort14489;
		public int getDefaultPort() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::org.apache.http.conn.scheme.Scheme._getDefaultPort14489);
			else
				return @__env.CallNonVirtualIntMethod(this, global::org.apache.http.conn.scheme.Scheme.staticClass, global::org.apache.http.conn.scheme.Scheme._getDefaultPort14489);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSocketFactory14490;
		public global::org.apache.http.conn.scheme.SocketFactory getSocketFactory() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.conn.scheme.SocketFactory>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.conn.scheme.Scheme._getSocketFactory14490));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.conn.scheme.SocketFactory>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.conn.scheme.Scheme.staticClass, global::org.apache.http.conn.scheme.Scheme._getSocketFactory14490));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isLayered14491;
		public bool isLayered() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.apache.http.conn.scheme.Scheme._isLayered14491);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.apache.http.conn.scheme.Scheme.staticClass, global::org.apache.http.conn.scheme.Scheme._isLayered14491);
		}
		internal static global::net.sf.jni4net.jni.MethodId _resolvePort14492;
		public int resolvePort(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::org.apache.http.conn.scheme.Scheme._resolvePort14492, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::org.apache.http.conn.scheme.Scheme.staticClass, global::org.apache.http.conn.scheme.Scheme._resolvePort14492, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Scheme14493;
		public Scheme(java.lang.String arg0, org.apache.http.conn.scheme.SocketFactory arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(org.apache.http.conn.scheme.Scheme.staticClass, global::org.apache.http.conn.scheme.Scheme._Scheme14493, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::org.apache.http.conn.scheme.Scheme.staticClass = @__class;
			global::org.apache.http.conn.scheme.Scheme._equals14485 = @__env.GetMethodID(global::org.apache.http.conn.scheme.Scheme.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::org.apache.http.conn.scheme.Scheme._toString14486 = @__env.GetMethodID(global::org.apache.http.conn.scheme.Scheme.staticClass, "toString", "()Ljava/lang/String;");
			global::org.apache.http.conn.scheme.Scheme._hashCode14487 = @__env.GetMethodID(global::org.apache.http.conn.scheme.Scheme.staticClass, "hashCode", "()I");
			global::org.apache.http.conn.scheme.Scheme._getName14488 = @__env.GetMethodID(global::org.apache.http.conn.scheme.Scheme.staticClass, "getName", "()Ljava/lang/String;");
			global::org.apache.http.conn.scheme.Scheme._getDefaultPort14489 = @__env.GetMethodID(global::org.apache.http.conn.scheme.Scheme.staticClass, "getDefaultPort", "()I");
			global::org.apache.http.conn.scheme.Scheme._getSocketFactory14490 = @__env.GetMethodID(global::org.apache.http.conn.scheme.Scheme.staticClass, "getSocketFactory", "()Lorg/apache/http/conn/scheme/SocketFactory;");
			global::org.apache.http.conn.scheme.Scheme._isLayered14491 = @__env.GetMethodID(global::org.apache.http.conn.scheme.Scheme.staticClass, "isLayered", "()Z");
			global::org.apache.http.conn.scheme.Scheme._resolvePort14492 = @__env.GetMethodID(global::org.apache.http.conn.scheme.Scheme.staticClass, "resolvePort", "(I)I");
			global::org.apache.http.conn.scheme.Scheme._Scheme14493 = @__env.GetMethodID(global::org.apache.http.conn.scheme.Scheme.staticClass, "<init>", "(Ljava/lang/String;Lorg/apache/http/conn/scheme/SocketFactory;I)V");
		}
	}
}
