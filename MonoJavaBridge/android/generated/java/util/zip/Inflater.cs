namespace java.util.zip
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Inflater : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Inflater(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize28401;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.Inflater.staticClass, "finalize", "()V", ref global::java.util.zip.Inflater._finalize28401);
		}
		internal static global::MonoJavaBridge.MethodId _reset28402;
		public virtual void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.Inflater.staticClass, "reset", "()V", ref global::java.util.zip.Inflater._reset28402);
		}
		internal static global::MonoJavaBridge.MethodId _finished28403;
		public virtual bool finished()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.zip.Inflater.staticClass, "finished", "()Z", ref global::java.util.zip.Inflater._finished28403);
		}
		internal static global::MonoJavaBridge.MethodId _end28404;
		public virtual void end()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.Inflater.staticClass, "end", "()V", ref global::java.util.zip.Inflater._end28404);
		}
		internal static global::MonoJavaBridge.MethodId _setInput28405;
		public virtual void setInput(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.Inflater.staticClass, "setInput", "([BII)V", ref global::java.util.zip.Inflater._setInput28405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new byte[] Input
		{
			set
			{
				setInput(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setInput28406;
		public virtual void setInput(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.Inflater.staticClass, "setInput", "([B)V", ref global::java.util.zip.Inflater._setInput28406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long BytesWritten
		{
			get
			{
				return getBytesWritten();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBytesWritten28407;
		public virtual long getBytesWritten()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.zip.Inflater.staticClass, "getBytesWritten", "()J", ref global::java.util.zip.Inflater._getBytesWritten28407);
		}
		internal static global::MonoJavaBridge.MethodId _inflate28408;
		public virtual int inflate(byte[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.zip.Inflater.staticClass, "inflate", "([B)I", ref global::java.util.zip.Inflater._inflate28408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _inflate28409;
		public virtual int inflate(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.zip.Inflater.staticClass, "inflate", "([BII)I", ref global::java.util.zip.Inflater._inflate28409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _needsDictionary28410;
		public virtual bool needsDictionary()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.zip.Inflater.staticClass, "needsDictionary", "()Z", ref global::java.util.zip.Inflater._needsDictionary28410);
		}
		internal static global::MonoJavaBridge.MethodId _needsInput28411;
		public virtual bool needsInput()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.zip.Inflater.staticClass, "needsInput", "()Z", ref global::java.util.zip.Inflater._needsInput28411);
		}
		internal static global::MonoJavaBridge.MethodId _setDictionary28412;
		public virtual void setDictionary(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.Inflater.staticClass, "setDictionary", "([BII)V", ref global::java.util.zip.Inflater._setDictionary28412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new byte[] Dictionary
		{
			set
			{
				setDictionary(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setDictionary28413;
		public virtual void setDictionary(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.Inflater.staticClass, "setDictionary", "([B)V", ref global::java.util.zip.Inflater._setDictionary28413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Remaining
		{
			get
			{
				return getRemaining();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRemaining28414;
		public virtual int getRemaining()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.zip.Inflater.staticClass, "getRemaining", "()I", ref global::java.util.zip.Inflater._getRemaining28414);
		}
		public new int Adler
		{
			get
			{
				return getAdler();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAdler28415;
		public virtual int getAdler()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.zip.Inflater.staticClass, "getAdler", "()I", ref global::java.util.zip.Inflater._getAdler28415);
		}
		public new int TotalIn
		{
			get
			{
				return getTotalIn();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTotalIn28416;
		public virtual int getTotalIn()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.zip.Inflater.staticClass, "getTotalIn", "()I", ref global::java.util.zip.Inflater._getTotalIn28416);
		}
		public new long BytesRead
		{
			get
			{
				return getBytesRead();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBytesRead28417;
		public virtual long getBytesRead()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.zip.Inflater.staticClass, "getBytesRead", "()J", ref global::java.util.zip.Inflater._getBytesRead28417);
		}
		public new int TotalOut
		{
			get
			{
				return getTotalOut();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTotalOut28418;
		public virtual int getTotalOut()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.zip.Inflater.staticClass, "getTotalOut", "()I", ref global::java.util.zip.Inflater._getTotalOut28418);
		}
		internal static global::MonoJavaBridge.MethodId _Inflater28419;
		public Inflater(bool arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.Inflater._Inflater28419.native == global::System.IntPtr.Zero)
				global::java.util.zip.Inflater._Inflater28419 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "<init>", "(Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._Inflater28419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Inflater28420;
		public Inflater() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.Inflater._Inflater28420.native == global::System.IntPtr.Zero)
				global::java.util.zip.Inflater._Inflater28420 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._Inflater28420);
			Init(@__env, handle);
		}
		static Inflater()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.Inflater.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/Inflater"));
		}
		internal static void InitJNI()
		{
		}
	}
}
