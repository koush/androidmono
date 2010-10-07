namespace java.nio.channels
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class SelectionKey : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static SelectionKey()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.nio.channels.SelectionKey), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected SelectionKey(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _channel12978;
		public abstract global::java.nio.channels.SelectableChannel channel();
		internal static global::net.sf.jni4net.jni.MethodId _isValid12979;
		public abstract bool isValid();
		internal static global::net.sf.jni4net.jni.MethodId _cancel12980;
		public abstract void cancel();
		internal static global::net.sf.jni4net.jni.MethodId _selector12981;
		public abstract global::java.nio.channels.Selector selector();
		internal static global::net.sf.jni4net.jni.MethodId _interestOps12982;
		public abstract int interestOps();
		internal static global::net.sf.jni4net.jni.MethodId _interestOps12983;
		public abstract global::java.nio.channels.SelectionKey interestOps(int arg0);
		internal static global::net.sf.jni4net.jni.MethodId _attach12984;
		public virtual global::java.lang.Object attach(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.channels.SelectionKey._attach12984, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.channels.SelectionKey.staticClass, global::java.nio.channels.SelectionKey._attach12984, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _attachment12985;
		public virtual global::java.lang.Object attachment() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.channels.SelectionKey._attachment12985));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.channels.SelectionKey.staticClass, global::java.nio.channels.SelectionKey._attachment12985));
		}
		internal static global::net.sf.jni4net.jni.MethodId _readyOps12986;
		public abstract int readyOps();
		internal static global::net.sf.jni4net.jni.MethodId _isReadable12987;
		public virtual bool isReadable() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.nio.channels.SelectionKey._isReadable12987);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.nio.channels.SelectionKey.staticClass, global::java.nio.channels.SelectionKey._isReadable12987);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isWritable12988;
		public virtual bool isWritable() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.nio.channels.SelectionKey._isWritable12988);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.nio.channels.SelectionKey.staticClass, global::java.nio.channels.SelectionKey._isWritable12988);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isConnectable12989;
		public virtual bool isConnectable() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.nio.channels.SelectionKey._isConnectable12989);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.nio.channels.SelectionKey.staticClass, global::java.nio.channels.SelectionKey._isConnectable12989);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isAcceptable12990;
		public virtual bool isAcceptable() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.nio.channels.SelectionKey._isAcceptable12990);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.nio.channels.SelectionKey.staticClass, global::java.nio.channels.SelectionKey._isAcceptable12990);
		}
		internal static global::net.sf.jni4net.jni.MethodId _SelectionKey12991;
		protected SelectionKey()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.nio.channels.SelectionKey.staticClass, global::java.nio.channels.SelectionKey._SelectionKey12991, this);
		}
		public static int OP_READ
		{
			get
			{
				return 1;
			}
		}
		public static int OP_WRITE
		{
			get
			{
				return 4;
			}
		}
		public static int OP_CONNECT
		{
			get
			{
				return 8;
			}
		}
		public static int OP_ACCEPT
		{
			get
			{
				return 16;
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.nio.channels.SelectionKey.staticClass = @__class;
			global::java.nio.channels.SelectionKey._channel12978 = @__env.GetMethodID(global::java.nio.channels.SelectionKey.staticClass, "channel", "()Ljava/nio/channels/SelectableChannel;");
			global::java.nio.channels.SelectionKey._isValid12979 = @__env.GetMethodID(global::java.nio.channels.SelectionKey.staticClass, "isValid", "()Z");
			global::java.nio.channels.SelectionKey._cancel12980 = @__env.GetMethodID(global::java.nio.channels.SelectionKey.staticClass, "cancel", "()V");
			global::java.nio.channels.SelectionKey._selector12981 = @__env.GetMethodID(global::java.nio.channels.SelectionKey.staticClass, "selector", "()Ljava/nio/channels/Selector;");
			global::java.nio.channels.SelectionKey._interestOps12982 = @__env.GetMethodID(global::java.nio.channels.SelectionKey.staticClass, "interestOps", "()I");
			global::java.nio.channels.SelectionKey._interestOps12983 = @__env.GetMethodID(global::java.nio.channels.SelectionKey.staticClass, "interestOps", "(I)Ljava/nio/channels/SelectionKey;");
			global::java.nio.channels.SelectionKey._attach12984 = @__env.GetMethodID(global::java.nio.channels.SelectionKey.staticClass, "attach", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.nio.channels.SelectionKey._attachment12985 = @__env.GetMethodID(global::java.nio.channels.SelectionKey.staticClass, "attachment", "()Ljava/lang/Object;");
			global::java.nio.channels.SelectionKey._readyOps12986 = @__env.GetMethodID(global::java.nio.channels.SelectionKey.staticClass, "readyOps", "()I");
			global::java.nio.channels.SelectionKey._isReadable12987 = @__env.GetMethodID(global::java.nio.channels.SelectionKey.staticClass, "isReadable", "()Z");
			global::java.nio.channels.SelectionKey._isWritable12988 = @__env.GetMethodID(global::java.nio.channels.SelectionKey.staticClass, "isWritable", "()Z");
			global::java.nio.channels.SelectionKey._isConnectable12989 = @__env.GetMethodID(global::java.nio.channels.SelectionKey.staticClass, "isConnectable", "()Z");
			global::java.nio.channels.SelectionKey._isAcceptable12990 = @__env.GetMethodID(global::java.nio.channels.SelectionKey.staticClass, "isAcceptable", "()Z");
			global::java.nio.channels.SelectionKey._SelectionKey12991 = @__env.GetMethodID(global::java.nio.channels.SelectionKey.staticClass, "<init>", "()V");
		}
	}
}
