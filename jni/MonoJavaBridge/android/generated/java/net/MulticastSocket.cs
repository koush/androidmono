namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MulticastSocket : java.net.DatagramSocket
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MulticastSocket()
		{
			InitJNI();
		}
		protected MulticastSocket(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _send21491;
		public virtual void send(java.net.DatagramPacket arg0, byte arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.MulticastSocket._send21491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._send21491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _bind21492;
		public override void bind(java.net.SocketAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.MulticastSocket._bind21492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._bind21492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTTL21493;
		public virtual void setTTL(byte arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.MulticastSocket._setTTL21493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._setTTL21493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new byte TTL
		{
			get
			{
				return getTTL();
			}
			set
			{
				setTTL(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTTL21494;
		public virtual byte getTTL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.net.MulticastSocket._getTTL21494);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._getTTL21494);
		}
		internal static global::MonoJavaBridge.MethodId _setTimeToLive21495;
		public virtual void setTimeToLive(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.MulticastSocket._setTimeToLive21495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._setTimeToLive21495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int TimeToLive
		{
			get
			{
				return getTimeToLive();
			}
			set
			{
				setTimeToLive(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTimeToLive21496;
		public virtual int getTimeToLive() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.MulticastSocket._getTimeToLive21496);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._getTimeToLive21496);
		}
		internal static global::MonoJavaBridge.MethodId _joinGroup21497;
		public virtual void joinGroup(java.net.SocketAddress arg0, java.net.NetworkInterface arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.MulticastSocket._joinGroup21497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._joinGroup21497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _joinGroup21498;
		public virtual void joinGroup(java.net.InetAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.MulticastSocket._joinGroup21498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._joinGroup21498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _leaveGroup21499;
		public virtual void leaveGroup(java.net.SocketAddress arg0, java.net.NetworkInterface arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.MulticastSocket._leaveGroup21499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._leaveGroup21499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _leaveGroup21500;
		public virtual void leaveGroup(java.net.InetAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.MulticastSocket._leaveGroup21500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._leaveGroup21500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setInterface21501;
		public virtual void setInterface(java.net.InetAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.MulticastSocket._setInterface21501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._setInterface21501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.net.InetAddress Interface
		{
			get
			{
				return getInterface();
			}
			set
			{
				setInterface(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInterface21502;
		public virtual global::java.net.InetAddress getInterface() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.MulticastSocket._getInterface21502)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._getInterface21502)) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _setNetworkInterface21503;
		public virtual void setNetworkInterface(java.net.NetworkInterface arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.MulticastSocket._setNetworkInterface21503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._setNetworkInterface21503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.net.NetworkInterface NetworkInterface
		{
			get
			{
				return getNetworkInterface();
			}
			set
			{
				setNetworkInterface(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNetworkInterface21504;
		public virtual global::java.net.NetworkInterface getNetworkInterface() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.NetworkInterface>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.MulticastSocket._getNetworkInterface21504)) as java.net.NetworkInterface;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.NetworkInterface>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._getNetworkInterface21504)) as java.net.NetworkInterface;
		}
		internal static global::MonoJavaBridge.MethodId _setLoopbackMode21505;
		public virtual void setLoopbackMode(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.MulticastSocket._setLoopbackMode21505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._setLoopbackMode21505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool LoopbackMode
		{
			get
			{
				return getLoopbackMode();
			}
			set
			{
				setLoopbackMode(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLoopbackMode21506;
		public virtual bool getLoopbackMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.MulticastSocket._getLoopbackMode21506);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._getLoopbackMode21506);
		}
		internal static global::MonoJavaBridge.MethodId _MulticastSocket21507;
		public MulticastSocket()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._MulticastSocket21507);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _MulticastSocket21508;
		public MulticastSocket(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._MulticastSocket21508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _MulticastSocket21509;
		public MulticastSocket(java.net.SocketAddress arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._MulticastSocket21509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.MulticastSocket.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/MulticastSocket"));
			global::java.net.MulticastSocket._send21491 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "send", "(Ljava/net/DatagramPacket;B)V");
			global::java.net.MulticastSocket._bind21492 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "bind", "(Ljava/net/SocketAddress;)V");
			global::java.net.MulticastSocket._setTTL21493 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "setTTL", "(B)V");
			global::java.net.MulticastSocket._getTTL21494 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "getTTL", "()B");
			global::java.net.MulticastSocket._setTimeToLive21495 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "setTimeToLive", "(I)V");
			global::java.net.MulticastSocket._getTimeToLive21496 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "getTimeToLive", "()I");
			global::java.net.MulticastSocket._joinGroup21497 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "joinGroup", "(Ljava/net/SocketAddress;Ljava/net/NetworkInterface;)V");
			global::java.net.MulticastSocket._joinGroup21498 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "joinGroup", "(Ljava/net/InetAddress;)V");
			global::java.net.MulticastSocket._leaveGroup21499 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "leaveGroup", "(Ljava/net/SocketAddress;Ljava/net/NetworkInterface;)V");
			global::java.net.MulticastSocket._leaveGroup21500 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "leaveGroup", "(Ljava/net/InetAddress;)V");
			global::java.net.MulticastSocket._setInterface21501 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "setInterface", "(Ljava/net/InetAddress;)V");
			global::java.net.MulticastSocket._getInterface21502 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "getInterface", "()Ljava/net/InetAddress;");
			global::java.net.MulticastSocket._setNetworkInterface21503 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "setNetworkInterface", "(Ljava/net/NetworkInterface;)V");
			global::java.net.MulticastSocket._getNetworkInterface21504 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "getNetworkInterface", "()Ljava/net/NetworkInterface;");
			global::java.net.MulticastSocket._setLoopbackMode21505 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "setLoopbackMode", "(Z)V");
			global::java.net.MulticastSocket._getLoopbackMode21506 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "getLoopbackMode", "()Z");
			global::java.net.MulticastSocket._MulticastSocket21507 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "<init>", "()V");
			global::java.net.MulticastSocket._MulticastSocket21508 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "<init>", "(I)V");
			global::java.net.MulticastSocket._MulticastSocket21509 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "<init>", "(Ljava/net/SocketAddress;)V");
		}
	}
}
