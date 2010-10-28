namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InetSocketAddress : java.net.SocketAddress
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected InetSocketAddress(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals21586;
		public sealed override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetSocketAddress._equals21586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetSocketAddress.staticClass, global::java.net.InetSocketAddress._equals21586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString21587;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.InetSocketAddress._toString21587)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.InetSocketAddress.staticClass, global::java.net.InetSocketAddress._toString21587)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode21588;
		public sealed override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.InetSocketAddress._hashCode21588);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.InetSocketAddress.staticClass, global::java.net.InetSocketAddress._hashCode21588);
		}
		public new global::java.net.InetAddress Address
		{
			get
			{
				return getAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAddress21589;
		public virtual global::java.net.InetAddress getAddress()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.InetSocketAddress._getAddress21589)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.InetSocketAddress.staticClass, global::java.net.InetSocketAddress._getAddress21589)) as java.net.InetAddress;
		}
		public new int Port
		{
			get
			{
				return getPort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPort21590;
		public virtual int getPort()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.InetSocketAddress._getPort21590);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.InetSocketAddress.staticClass, global::java.net.InetSocketAddress._getPort21590);
		}
		internal static global::MonoJavaBridge.MethodId _isUnresolved21591;
		public virtual bool isUnresolved()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetSocketAddress._isUnresolved21591);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetSocketAddress.staticClass, global::java.net.InetSocketAddress._isUnresolved21591);
		}
		public new global::java.lang.String HostName
		{
			get
			{
				return getHostName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHostName21592;
		public virtual global::java.lang.String getHostName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.InetSocketAddress._getHostName21592)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.InetSocketAddress.staticClass, global::java.net.InetSocketAddress._getHostName21592)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _createUnresolved21593;
		public static global::java.net.InetSocketAddress createUnresolved(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.InetSocketAddress.staticClass, global::java.net.InetSocketAddress._createUnresolved21593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.net.InetSocketAddress;
		}
		internal static global::MonoJavaBridge.MethodId _InetSocketAddress21594;
		public InetSocketAddress(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.InetSocketAddress.staticClass, global::java.net.InetSocketAddress._InetSocketAddress21594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InetSocketAddress21595;
		public InetSocketAddress(java.net.InetAddress arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.InetSocketAddress.staticClass, global::java.net.InetSocketAddress._InetSocketAddress21595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InetSocketAddress21596;
		public InetSocketAddress(java.lang.String arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.InetSocketAddress.staticClass, global::java.net.InetSocketAddress._InetSocketAddress21596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static InetSocketAddress()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.InetSocketAddress.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/InetSocketAddress"));
			global::java.net.InetSocketAddress._equals21586 = @__env.GetMethodIDNoThrow(global::java.net.InetSocketAddress.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.net.InetSocketAddress._toString21587 = @__env.GetMethodIDNoThrow(global::java.net.InetSocketAddress.staticClass, "toString", "()Ljava/lang/String;");
			global::java.net.InetSocketAddress._hashCode21588 = @__env.GetMethodIDNoThrow(global::java.net.InetSocketAddress.staticClass, "hashCode", "()I");
			global::java.net.InetSocketAddress._getAddress21589 = @__env.GetMethodIDNoThrow(global::java.net.InetSocketAddress.staticClass, "getAddress", "()Ljava/net/InetAddress;");
			global::java.net.InetSocketAddress._getPort21590 = @__env.GetMethodIDNoThrow(global::java.net.InetSocketAddress.staticClass, "getPort", "()I");
			global::java.net.InetSocketAddress._isUnresolved21591 = @__env.GetMethodIDNoThrow(global::java.net.InetSocketAddress.staticClass, "isUnresolved", "()Z");
			global::java.net.InetSocketAddress._getHostName21592 = @__env.GetMethodIDNoThrow(global::java.net.InetSocketAddress.staticClass, "getHostName", "()Ljava/lang/String;");
			global::java.net.InetSocketAddress._createUnresolved21593 = @__env.GetStaticMethodIDNoThrow(global::java.net.InetSocketAddress.staticClass, "createUnresolved", "(Ljava/lang/String;I)Ljava/net/InetSocketAddress;");
			global::java.net.InetSocketAddress._InetSocketAddress21594 = @__env.GetMethodIDNoThrow(global::java.net.InetSocketAddress.staticClass, "<init>", "(I)V");
			global::java.net.InetSocketAddress._InetSocketAddress21595 = @__env.GetMethodIDNoThrow(global::java.net.InetSocketAddress.staticClass, "<init>", "(Ljava/net/InetAddress;I)V");
			global::java.net.InetSocketAddress._InetSocketAddress21596 = @__env.GetMethodIDNoThrow(global::java.net.InetSocketAddress.staticClass, "<init>", "(Ljava/lang/String;I)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
