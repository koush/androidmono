namespace java.util.zip
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Inflater : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Inflater(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.Inflater.staticClass, "finalize", "()V", ref global::java.util.zip.Inflater._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.Inflater.staticClass, "reset", "()V", ref global::java.util.zip.Inflater._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual bool finished()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.zip.Inflater.staticClass, "finished", "()Z", ref global::java.util.zip.Inflater._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void end()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.Inflater.staticClass, "end", "()V", ref global::java.util.zip.Inflater._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void setInput(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.Inflater.staticClass, "setInput", "([BII)V", ref global::java.util.zip.Inflater._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new byte[] Input
		{
			set
			{
				setInput(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setInput(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.Inflater.staticClass, "setInput", "([B)V", ref global::java.util.zip.Inflater._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.zip.Inflater.staticClass, "getBytesWritten", "()J", ref global::java.util.zip.Inflater._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual int inflate(byte[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.zip.Inflater.staticClass, "inflate", "([B)I", ref global::java.util.zip.Inflater._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual int inflate(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.zip.Inflater.staticClass, "inflate", "([BII)I", ref global::java.util.zip.Inflater._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual bool needsDictionary()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.zip.Inflater.staticClass, "needsDictionary", "()Z", ref global::java.util.zip.Inflater._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual bool needsInput()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.zip.Inflater.staticClass, "needsInput", "()Z", ref global::java.util.zip.Inflater._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void setDictionary(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.Inflater.staticClass, "setDictionary", "([BII)V", ref global::java.util.zip.Inflater._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new byte[] Dictionary
		{
			set
			{
				setDictionary(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void setDictionary(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.Inflater.staticClass, "setDictionary", "([B)V", ref global::java.util.zip.Inflater._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Remaining
		{
			get
			{
				return getRemaining();
			}
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual int getRemaining()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.zip.Inflater.staticClass, "getRemaining", "()I", ref global::java.util.zip.Inflater._m13);
		}
		public new int Adler
		{
			get
			{
				return getAdler();
			}
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual int getAdler()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.zip.Inflater.staticClass, "getAdler", "()I", ref global::java.util.zip.Inflater._m14);
		}
		public new int TotalIn
		{
			get
			{
				return getTotalIn();
			}
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual int getTotalIn()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.zip.Inflater.staticClass, "getTotalIn", "()I", ref global::java.util.zip.Inflater._m15);
		}
		public new long BytesRead
		{
			get
			{
				return getBytesRead();
			}
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual long getBytesRead()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.zip.Inflater.staticClass, "getBytesRead", "()J", ref global::java.util.zip.Inflater._m16);
		}
		public new int TotalOut
		{
			get
			{
				return getTotalOut();
			}
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual int getTotalOut()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.zip.Inflater.staticClass, "getTotalOut", "()I", ref global::java.util.zip.Inflater._m17);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public Inflater(bool arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.Inflater._m18.native == global::System.IntPtr.Zero)
				global::java.util.zip.Inflater._m18 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "<init>", "(Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public Inflater() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.Inflater._m19.native == global::System.IntPtr.Zero)
				global::java.util.zip.Inflater._m19 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._m19);
			Init(@__env, handle);
		}
		static Inflater()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.Inflater.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/Inflater"));
		}
	}
}
