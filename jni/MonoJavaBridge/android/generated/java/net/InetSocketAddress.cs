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
		internal static global::MonoJavaBridge.MethodId _equals21467;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetSocketAddress._equals21467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetSocketAddress.staticClass, global::java.net.InetSocketAddress._equals21467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString21468;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.InetSocketAddress._toString21468)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.InetSocketAddress.staticClass, global::java.net.InetSocketAddress._toString21468)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode21469;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.InetSocketAddress._hashCode21469);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.InetSocketAddress.staticClass, global::java.net.InetSocketAddress._hashCode21469);
		}
		public new global::java.net.InetAddress Address
		{
			get
			{
				return getAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAddress21470;
		public virtual global::java.net.InetAddress getAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.InetSocketAddress._getAddress21470)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.InetSocketAddress.staticClass, global::java.net.InetSocketAddress._getAddress21470)) as java.net.InetAddress;
		}
		public new int Port
		{
			get
			{
				return getPort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPort21471;
		public virtual int getPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.InetSocketAddress._getPort21471);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.InetSocketAddress.staticClass, global::java.net.InetSocketAddress._getPort21471);
		}
		internal static global::MonoJavaBridge.MethodId _isUnresolved21472;
		public virtual bool isUnresolved() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetSocketAddress._isUnresolved21472);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetSocketAddress.staticClass, global::java.net.InetSocketAddress._isUnresolved21472);
		}
		public new global::java.lang.String HostName
		{
			get
			{
				return getHostName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHostName21473;
		public virtual global::java.lang.String getHostName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.InetSocketAddress._getHostName21473)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.InetSocketAddress.staticClass, global::java.net.InetSocketAddress._getHostName21473)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _createUnresolved21474;
		public static global::java.net.InetSocketAddress createUnresolved(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.InetSocketAddress.staticClass, global::java.net.InetSocketAddress._createUnresolved21474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.net.InetSocketAddress;
		}
		internal static global::MonoJavaBridge.MethodId _InetSocketAddress21475;
		public InetSocketAddress(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.InetSocketAddress.staticClass, global::java.net.InetSocketAddress._InetSocketAddress21475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InetSocketAddress21476;
		public InetSocketAddress(java.net.InetAddress arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.InetSocketAddress.staticClass, global::java.net.InetSocketAddress._InetSocketAddress21476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InetSocketAddress21477;
		public InetSocketAddress(java.lang.String arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.InetSocketAddress.staticClass, global::java.net.InetSocketAddress._InetSocketAddress21477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.InetSocketAddress.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/InetSocketAddress"));
			global::java.net.InetSocketAddress._equals21467 = @__env.GetMethodIDNoThrow(global::java.net.InetSocketAddress.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.net.InetSocketAddress._toString21468 = @__env.GetMethodIDNoThrow(global::java.net.InetSocketAddress.staticClass, "toString", "()Ljava/lang/String;");
			global::java.net.InetSocketAddress._hashCode21469 = @__env.GetMethodIDNoThrow(global::java.net.InetSocketAddress.staticClass, "hashCode", "()I");
			global::java.net.InetSocketAddress._getAddress21470 = @__env.GetMethodIDNoThrow(global::java.net.InetSocketAddress.staticClass, "getAddress", "()Ljava/net/InetAddress;");
			global::java.net.InetSocketAddress._getPort21471 = @__env.GetMethodIDNoThrow(global::java.net.InetSocketAddress.staticClass, "getPort", "()I");
			global::java.net.InetSocketAddress._isUnresolved21472 = @__env.GetMethodIDNoThrow(global::java.net.InetSocketAddress.staticClass, "isUnresolved", "()Z");
			global::java.net.InetSocketAddress._getHostName21473 = @__env.GetMethodIDNoThrow(global::java.net.InetSocketAddress.staticClass, "getHostName", "()Ljava/lang/String;");
			global::java.net.InetSocketAddress._createUnresolved21474 = @__env.GetStaticMethodIDNoThrow(global::java.net.InetSocketAddress.staticClass, "createUnresolved", "(Ljava/lang/String;I)Ljava/net/InetSocketAddress;");
			global::java.net.InetSocketAddress._InetSocketAddress21475 = @__env.GetMethodIDNoThrow(global::java.net.InetSocketAddress.staticClass, "<init>", "(I)V");
			global::java.net.InetSocketAddress._InetSocketAddress21476 = @__env.GetMethodIDNoThrow(global::java.net.InetSocketAddress.staticClass, "<init>", "(Ljava/net/InetAddress;I)V");
			global::java.net.InetSocketAddress._InetSocketAddress21477 = @__env.GetMethodIDNoThrow(global::java.net.InetSocketAddress.staticClass, "<init>", "(Ljava/lang/String;I)V");
		}
	}
}
