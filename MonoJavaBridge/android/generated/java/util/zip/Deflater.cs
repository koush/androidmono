namespace java.util.zip
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Deflater : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Deflater(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.Deflater.staticClass, "finalize", "()V", ref global::java.util.zip.Deflater._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.Deflater.staticClass, "reset", "()V", ref global::java.util.zip.Deflater._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual bool finished()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.zip.Deflater.staticClass, "finished", "()Z", ref global::java.util.zip.Deflater._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void end()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.Deflater.staticClass, "end", "()V", ref global::java.util.zip.Deflater._m3);
		}
		public new byte[] Input
		{
			set
			{
				setInput(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void setInput(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.Deflater.staticClass, "setInput", "([B)V", ref global::java.util.zip.Deflater._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setInput(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.Deflater.staticClass, "setInput", "([BII)V", ref global::java.util.zip.Deflater._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new long BytesWritten
		{
			get
			{
				return getBytesWritten();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual long getBytesWritten()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.zip.Deflater.staticClass, "getBytesWritten", "()J", ref global::java.util.zip.Deflater._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual bool needsInput()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.zip.Deflater.staticClass, "needsInput", "()Z", ref global::java.util.zip.Deflater._m7);
		}
		public new byte[] Dictionary
		{
			set
			{
				setDictionary(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setDictionary(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.Deflater.staticClass, "setDictionary", "([B)V", ref global::java.util.zip.Deflater._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void setDictionary(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.Deflater.staticClass, "setDictionary", "([BII)V", ref global::java.util.zip.Deflater._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new int Adler
		{
			get
			{
				return getAdler();
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual int getAdler()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.zip.Deflater.staticClass, "getAdler", "()I", ref global::java.util.zip.Deflater._m10);
		}
		public new int TotalIn
		{
			get
			{
				return getTotalIn();
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual int getTotalIn()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.zip.Deflater.staticClass, "getTotalIn", "()I", ref global::java.util.zip.Deflater._m11);
		}
		public new long BytesRead
		{
			get
			{
				return getBytesRead();
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual long getBytesRead()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.zip.Deflater.staticClass, "getBytesRead", "()J", ref global::java.util.zip.Deflater._m12);
		}
		public new int TotalOut
		{
			get
			{
				return getTotalOut();
			}
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual int getTotalOut()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.zip.Deflater.staticClass, "getTotalOut", "()I", ref global::java.util.zip.Deflater._m13);
		}
		public new int Level
		{
			set
			{
				setLevel(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void setLevel(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.Deflater.staticClass, "setLevel", "(I)V", ref global::java.util.zip.Deflater._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void finish()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.Deflater.staticClass, "finish", "()V", ref global::java.util.zip.Deflater._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual int deflate(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.zip.Deflater.staticClass, "deflate", "([BII)I", ref global::java.util.zip.Deflater._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual int deflate(byte[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.zip.Deflater.staticClass, "deflate", "([B)I", ref global::java.util.zip.Deflater._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Strategy
		{
			set
			{
				setStrategy(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void setStrategy(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.Deflater.staticClass, "setStrategy", "(I)V", ref global::java.util.zip.Deflater._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public Deflater(int arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.Deflater._m19.native == global::System.IntPtr.Zero)
				global::java.util.zip.Deflater._m19 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "<init>", "(IZ)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public Deflater(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.Deflater._m20.native == global::System.IntPtr.Zero)
				global::java.util.zip.Deflater._m20 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public Deflater() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.Deflater._m21.native == global::System.IntPtr.Zero)
				global::java.util.zip.Deflater._m21 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._m21);
			Init(@__env, handle);
		}
		public static int DEFLATED
		{
			get
			{
				return 8;
			}
		}
		public static int NO_COMPRESSION
		{
			get
			{
				return 0;
			}
		}
		public static int BEST_SPEED
		{
			get
			{
				return 1;
			}
		}
		public static int BEST_COMPRESSION
		{
			get
			{
				return 9;
			}
		}
		public static int DEFAULT_COMPRESSION
		{
			get
			{
				return -1;
			}
		}
		public static int FILTERED
		{
			get
			{
				return 1;
			}
		}
		public static int HUFFMAN_ONLY
		{
			get
			{
				return 2;
			}
		}
		public static int DEFAULT_STRATEGY
		{
			get
			{
				return 0;
			}
		}
		static Deflater()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.Deflater.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/Deflater"));
		}
	}
}
