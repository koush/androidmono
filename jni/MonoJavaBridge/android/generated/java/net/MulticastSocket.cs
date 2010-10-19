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
		internal static global::MonoJavaBridge.MethodId _send15911;
		public virtual void send(java.net.DatagramPacket arg0, byte arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.MulticastSocket._send15911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._send15911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _bind15912;
		public override void bind(java.net.SocketAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.MulticastSocket._bind15912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._bind15912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTTL15913;
		public virtual void setTTL(byte arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.MulticastSocket._setTTL15913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._setTTL15913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getTTL15914;
		public virtual byte getTTL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.net.MulticastSocket._getTTL15914);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._getTTL15914);
		}
		internal static global::MonoJavaBridge.MethodId _setTimeToLive15915;
		public virtual void setTimeToLive(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.MulticastSocket._setTimeToLive15915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._setTimeToLive15915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getTimeToLive15916;
		public virtual int getTimeToLive() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.MulticastSocket._getTimeToLive15916);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._getTimeToLive15916);
		}
		internal static global::MonoJavaBridge.MethodId _joinGroup15917;
		public virtual void joinGroup(java.net.SocketAddress arg0, java.net.NetworkInterface arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.MulticastSocket._joinGroup15917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._joinGroup15917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _joinGroup15918;
		public virtual void joinGroup(java.net.InetAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.MulticastSocket._joinGroup15918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._joinGroup15918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _leaveGroup15919;
		public virtual void leaveGroup(java.net.SocketAddress arg0, java.net.NetworkInterface arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.MulticastSocket._leaveGroup15919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._leaveGroup15919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _leaveGroup15920;
		public virtual void leaveGroup(java.net.InetAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.MulticastSocket._leaveGroup15920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._leaveGroup15920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setInterface15921;
		public virtual void setInterface(java.net.InetAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.MulticastSocket._setInterface15921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._setInterface15921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getInterface15922;
		public virtual global::java.net.InetAddress getInterface() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.MulticastSocket._getInterface15922)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._getInterface15922)) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _setNetworkInterface15923;
		public virtual void setNetworkInterface(java.net.NetworkInterface arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.MulticastSocket._setNetworkInterface15923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._setNetworkInterface15923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getNetworkInterface15924;
		public virtual global::java.net.NetworkInterface getNetworkInterface() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.MulticastSocket._getNetworkInterface15924)) as java.net.NetworkInterface;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._getNetworkInterface15924)) as java.net.NetworkInterface;
		}
		internal static global::MonoJavaBridge.MethodId _setLoopbackMode15925;
		public virtual void setLoopbackMode(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.MulticastSocket._setLoopbackMode15925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._setLoopbackMode15925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getLoopbackMode15926;
		public virtual bool getLoopbackMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.MulticastSocket._getLoopbackMode15926);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._getLoopbackMode15926);
		}
		internal static global::MonoJavaBridge.MethodId _MulticastSocket15927;
		public MulticastSocket()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._MulticastSocket15927);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _MulticastSocket15928;
		public MulticastSocket(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._MulticastSocket15928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _MulticastSocket15929;
		public MulticastSocket(java.net.SocketAddress arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._MulticastSocket15929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.MulticastSocket.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/MulticastSocket"));
			global::java.net.MulticastSocket._send15911 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "send", "(Ljava/net/DatagramPacket;B)V");
			global::java.net.MulticastSocket._bind15912 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "bind", "(Ljava/net/SocketAddress;)V");
			global::java.net.MulticastSocket._setTTL15913 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "setTTL", "(B)V");
			global::java.net.MulticastSocket._getTTL15914 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "getTTL", "()B");
			global::java.net.MulticastSocket._setTimeToLive15915 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "setTimeToLive", "(I)V");
			global::java.net.MulticastSocket._getTimeToLive15916 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "getTimeToLive", "()I");
			global::java.net.MulticastSocket._joinGroup15917 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "joinGroup", "(Ljava/net/SocketAddress;Ljava/net/NetworkInterface;)V");
			global::java.net.MulticastSocket._joinGroup15918 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "joinGroup", "(Ljava/net/InetAddress;)V");
			global::java.net.MulticastSocket._leaveGroup15919 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "leaveGroup", "(Ljava/net/SocketAddress;Ljava/net/NetworkInterface;)V");
			global::java.net.MulticastSocket._leaveGroup15920 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "leaveGroup", "(Ljava/net/InetAddress;)V");
			global::java.net.MulticastSocket._setInterface15921 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "setInterface", "(Ljava/net/InetAddress;)V");
			global::java.net.MulticastSocket._getInterface15922 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "getInterface", "()Ljava/net/InetAddress;");
			global::java.net.MulticastSocket._setNetworkInterface15923 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "setNetworkInterface", "(Ljava/net/NetworkInterface;)V");
			global::java.net.MulticastSocket._getNetworkInterface15924 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "getNetworkInterface", "()Ljava/net/NetworkInterface;");
			global::java.net.MulticastSocket._setLoopbackMode15925 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "setLoopbackMode", "(Z)V");
			global::java.net.MulticastSocket._getLoopbackMode15926 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "getLoopbackMode", "()Z");
			global::java.net.MulticastSocket._MulticastSocket15927 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "<init>", "()V");
			global::java.net.MulticastSocket._MulticastSocket15928 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "<init>", "(I)V");
			global::java.net.MulticastSocket._MulticastSocket15929 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "<init>", "(Ljava/net/SocketAddress;)V");
		}
	}
}
