namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InetSocketAddress : java.net.SocketAddress
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static InetSocketAddress()
		{
			InitJNI();
		}
		protected InetSocketAddress(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals15887;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetSocketAddress._equals15887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetSocketAddress.staticClass, global::java.net.InetSocketAddress._equals15887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString15888;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.InetSocketAddress._toString15888)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.InetSocketAddress.staticClass, global::java.net.InetSocketAddress._toString15888)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode15889;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.InetSocketAddress._hashCode15889);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.InetSocketAddress.staticClass, global::java.net.InetSocketAddress._hashCode15889);
		}
		public new global::java.net.InetAddress Address
		{
			get
			{
				return getAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAddress15890;
		public virtual global::java.net.InetAddress getAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.InetSocketAddress._getAddress15890)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.InetSocketAddress.staticClass, global::java.net.InetSocketAddress._getAddress15890)) as java.net.InetAddress;
		}
		public new int Port
		{
			get
			{
				return getPort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPort15891;
		public virtual int getPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.InetSocketAddress._getPort15891);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.InetSocketAddress.staticClass, global::java.net.InetSocketAddress._getPort15891);
		}
		internal static global::MonoJavaBridge.MethodId _isUnresolved15892;
		public virtual bool isUnresolved() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetSocketAddress._isUnresolved15892);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetSocketAddress.staticClass, global::java.net.InetSocketAddress._isUnresolved15892);
		}
		public new global::java.lang.String HostName
		{
			get
			{
				return getHostName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHostName15893;
		public virtual global::java.lang.String getHostName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.InetSocketAddress._getHostName15893)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.InetSocketAddress.staticClass, global::java.net.InetSocketAddress._getHostName15893)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _createUnresolved15894;
		public static global::java.net.InetSocketAddress createUnresolved(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.InetSocketAddress.staticClass, global::java.net.InetSocketAddress._createUnresolved15894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.net.InetSocketAddress;
		}
		internal static global::MonoJavaBridge.MethodId _InetSocketAddress15895;
		public InetSocketAddress(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.InetSocketAddress.staticClass, global::java.net.InetSocketAddress._InetSocketAddress15895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InetSocketAddress15896;
		public InetSocketAddress(java.net.InetAddress arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.InetSocketAddress.staticClass, global::java.net.InetSocketAddress._InetSocketAddress15896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InetSocketAddress15897;
		public InetSocketAddress(java.lang.String arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.InetSocketAddress.staticClass, global::java.net.InetSocketAddress._InetSocketAddress15897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.InetSocketAddress.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/InetSocketAddress"));
			global::java.net.InetSocketAddress._equals15887 = @__env.GetMethodIDNoThrow(global::java.net.InetSocketAddress.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.net.InetSocketAddress._toString15888 = @__env.GetMethodIDNoThrow(global::java.net.InetSocketAddress.staticClass, "toString", "()Ljava/lang/String;");
			global::java.net.InetSocketAddress._hashCode15889 = @__env.GetMethodIDNoThrow(global::java.net.InetSocketAddress.staticClass, "hashCode", "()I");
			global::java.net.InetSocketAddress._getAddress15890 = @__env.GetMethodIDNoThrow(global::java.net.InetSocketAddress.staticClass, "getAddress", "()Ljava/net/InetAddress;");
			global::java.net.InetSocketAddress._getPort15891 = @__env.GetMethodIDNoThrow(global::java.net.InetSocketAddress.staticClass, "getPort", "()I");
			global::java.net.InetSocketAddress._isUnresolved15892 = @__env.GetMethodIDNoThrow(global::java.net.InetSocketAddress.staticClass, "isUnresolved", "()Z");
			global::java.net.InetSocketAddress._getHostName15893 = @__env.GetMethodIDNoThrow(global::java.net.InetSocketAddress.staticClass, "getHostName", "()Ljava/lang/String;");
			global::java.net.InetSocketAddress._createUnresolved15894 = @__env.GetStaticMethodIDNoThrow(global::java.net.InetSocketAddress.staticClass, "createUnresolved", "(Ljava/lang/String;I)Ljava/net/InetSocketAddress;");
			global::java.net.InetSocketAddress._InetSocketAddress15895 = @__env.GetMethodIDNoThrow(global::java.net.InetSocketAddress.staticClass, "<init>", "(I)V");
			global::java.net.InetSocketAddress._InetSocketAddress15896 = @__env.GetMethodIDNoThrow(global::java.net.InetSocketAddress.staticClass, "<init>", "(Ljava/net/InetAddress;I)V");
			global::java.net.InetSocketAddress._InetSocketAddress15897 = @__env.GetMethodIDNoThrow(global::java.net.InetSocketAddress.staticClass, "<init>", "(Ljava/lang/String;I)V");
		}
	}
}
