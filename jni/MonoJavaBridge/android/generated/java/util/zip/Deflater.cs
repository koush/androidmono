namespace java.util.zip
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Deflater : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Deflater()
		{
			InitJNI();
		}
		protected Deflater(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize22361;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Deflater._finalize22361);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._finalize22361);
		}
		internal static global::MonoJavaBridge.MethodId _reset22362;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Deflater._reset22362);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._reset22362);
		}
		internal static global::MonoJavaBridge.MethodId _finished22363;
		public virtual bool finished() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.zip.Deflater._finished22363);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._finished22363);
		}
		internal static global::MonoJavaBridge.MethodId _end22364;
		public virtual void end() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Deflater._end22364);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._end22364);
		}
		internal static global::MonoJavaBridge.MethodId _setInput22365;
		public virtual void setInput(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Deflater._setInput22365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._setInput22365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setInput22366;
		public virtual void setInput(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Deflater._setInput22366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._setInput22366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new long BytesWritten
		{
			get
			{
				return getBytesWritten();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBytesWritten22367;
		public virtual long getBytesWritten() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.zip.Deflater._getBytesWritten22367);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._getBytesWritten22367);
		}
		internal static global::MonoJavaBridge.MethodId _needsInput22368;
		public virtual bool needsInput() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.zip.Deflater._needsInput22368);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._needsInput22368);
		}
		internal static global::MonoJavaBridge.MethodId _setDictionary22369;
		public virtual void setDictionary(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Deflater._setDictionary22369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._setDictionary22369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDictionary22370;
		public virtual void setDictionary(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Deflater._setDictionary22370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._setDictionary22370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new int Adler
		{
			get
			{
				return getAdler();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAdler22371;
		public virtual int getAdler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.Deflater._getAdler22371);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._getAdler22371);
		}
		public new int TotalIn
		{
			get
			{
				return getTotalIn();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTotalIn22372;
		public virtual int getTotalIn() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.Deflater._getTotalIn22372);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._getTotalIn22372);
		}
		public new long BytesRead
		{
			get
			{
				return getBytesRead();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBytesRead22373;
		public virtual long getBytesRead() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.zip.Deflater._getBytesRead22373);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._getBytesRead22373);
		}
		public new int TotalOut
		{
			get
			{
				return getTotalOut();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTotalOut22374;
		public virtual int getTotalOut() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.Deflater._getTotalOut22374);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._getTotalOut22374);
		}
		internal static global::MonoJavaBridge.MethodId _setLevel22375;
		public virtual void setLevel(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Deflater._setLevel22375, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._setLevel22375, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _finish22376;
		public virtual void finish() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Deflater._finish22376);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._finish22376);
		}
		internal static global::MonoJavaBridge.MethodId _deflate22377;
		public virtual int deflate(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.Deflater._deflate22377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._deflate22377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _deflate22378;
		public virtual int deflate(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.Deflater._deflate22378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._deflate22378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setStrategy22379;
		public virtual void setStrategy(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Deflater._setStrategy22379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._setStrategy22379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Deflater22380;
		public Deflater(int arg0, bool arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._Deflater22380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Deflater22381;
		public Deflater(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._Deflater22381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Deflater22382;
		public Deflater()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._Deflater22382);
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.Deflater.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/Deflater"));
			global::java.util.zip.Deflater._finalize22361 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "finalize", "()V");
			global::java.util.zip.Deflater._reset22362 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "reset", "()V");
			global::java.util.zip.Deflater._finished22363 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "finished", "()Z");
			global::java.util.zip.Deflater._end22364 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "end", "()V");
			global::java.util.zip.Deflater._setInput22365 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "setInput", "([B)V");
			global::java.util.zip.Deflater._setInput22366 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "setInput", "([BII)V");
			global::java.util.zip.Deflater._getBytesWritten22367 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "getBytesWritten", "()J");
			global::java.util.zip.Deflater._needsInput22368 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "needsInput", "()Z");
			global::java.util.zip.Deflater._setDictionary22369 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "setDictionary", "([B)V");
			global::java.util.zip.Deflater._setDictionary22370 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "setDictionary", "([BII)V");
			global::java.util.zip.Deflater._getAdler22371 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "getAdler", "()I");
			global::java.util.zip.Deflater._getTotalIn22372 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "getTotalIn", "()I");
			global::java.util.zip.Deflater._getBytesRead22373 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "getBytesRead", "()J");
			global::java.util.zip.Deflater._getTotalOut22374 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "getTotalOut", "()I");
			global::java.util.zip.Deflater._setLevel22375 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "setLevel", "(I)V");
			global::java.util.zip.Deflater._finish22376 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "finish", "()V");
			global::java.util.zip.Deflater._deflate22377 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "deflate", "([BII)I");
			global::java.util.zip.Deflater._deflate22378 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "deflate", "([B)I");
			global::java.util.zip.Deflater._setStrategy22379 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "setStrategy", "(I)V");
			global::java.util.zip.Deflater._Deflater22380 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "<init>", "(IZ)V");
			global::java.util.zip.Deflater._Deflater22381 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "<init>", "(I)V");
			global::java.util.zip.Deflater._Deflater22382 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "<init>", "()V");
		}
	}
}
