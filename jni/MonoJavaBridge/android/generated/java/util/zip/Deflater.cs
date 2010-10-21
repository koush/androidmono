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
		internal static global::MonoJavaBridge.MethodId _finalize28235;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Deflater._finalize28235);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._finalize28235);
		}
		internal static global::MonoJavaBridge.MethodId _reset28236;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Deflater._reset28236);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._reset28236);
		}
		internal static global::MonoJavaBridge.MethodId _finished28237;
		public virtual bool finished() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.zip.Deflater._finished28237);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._finished28237);
		}
		internal static global::MonoJavaBridge.MethodId _end28238;
		public virtual void end() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Deflater._end28238);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._end28238);
		}
		internal static global::MonoJavaBridge.MethodId _setInput28239;
		public virtual void setInput(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Deflater._setInput28239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._setInput28239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setInput28240;
		public virtual void setInput(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Deflater._setInput28240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._setInput28240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new long BytesWritten
		{
			get
			{
				return getBytesWritten();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBytesWritten28241;
		public virtual long getBytesWritten() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.zip.Deflater._getBytesWritten28241);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._getBytesWritten28241);
		}
		internal static global::MonoJavaBridge.MethodId _needsInput28242;
		public virtual bool needsInput() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.zip.Deflater._needsInput28242);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._needsInput28242);
		}
		internal static global::MonoJavaBridge.MethodId _setDictionary28243;
		public virtual void setDictionary(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Deflater._setDictionary28243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._setDictionary28243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDictionary28244;
		public virtual void setDictionary(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Deflater._setDictionary28244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._setDictionary28244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new int Adler
		{
			get
			{
				return getAdler();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAdler28245;
		public virtual int getAdler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.Deflater._getAdler28245);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._getAdler28245);
		}
		public new int TotalIn
		{
			get
			{
				return getTotalIn();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTotalIn28246;
		public virtual int getTotalIn() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.Deflater._getTotalIn28246);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._getTotalIn28246);
		}
		public new long BytesRead
		{
			get
			{
				return getBytesRead();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBytesRead28247;
		public virtual long getBytesRead() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.zip.Deflater._getBytesRead28247);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._getBytesRead28247);
		}
		public new int TotalOut
		{
			get
			{
				return getTotalOut();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTotalOut28248;
		public virtual int getTotalOut() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.Deflater._getTotalOut28248);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._getTotalOut28248);
		}
		internal static global::MonoJavaBridge.MethodId _setLevel28249;
		public virtual void setLevel(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Deflater._setLevel28249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._setLevel28249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _finish28250;
		public virtual void finish() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Deflater._finish28250);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._finish28250);
		}
		internal static global::MonoJavaBridge.MethodId _deflate28251;
		public virtual int deflate(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.Deflater._deflate28251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._deflate28251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _deflate28252;
		public virtual int deflate(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.Deflater._deflate28252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._deflate28252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setStrategy28253;
		public virtual void setStrategy(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Deflater._setStrategy28253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._setStrategy28253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Deflater28254;
		public Deflater(int arg0, bool arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._Deflater28254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Deflater28255;
		public Deflater(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._Deflater28255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Deflater28256;
		public Deflater()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._Deflater28256);
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
			global::java.util.zip.Deflater._finalize28235 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "finalize", "()V");
			global::java.util.zip.Deflater._reset28236 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "reset", "()V");
			global::java.util.zip.Deflater._finished28237 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "finished", "()Z");
			global::java.util.zip.Deflater._end28238 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "end", "()V");
			global::java.util.zip.Deflater._setInput28239 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "setInput", "([B)V");
			global::java.util.zip.Deflater._setInput28240 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "setInput", "([BII)V");
			global::java.util.zip.Deflater._getBytesWritten28241 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "getBytesWritten", "()J");
			global::java.util.zip.Deflater._needsInput28242 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "needsInput", "()Z");
			global::java.util.zip.Deflater._setDictionary28243 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "setDictionary", "([B)V");
			global::java.util.zip.Deflater._setDictionary28244 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "setDictionary", "([BII)V");
			global::java.util.zip.Deflater._getAdler28245 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "getAdler", "()I");
			global::java.util.zip.Deflater._getTotalIn28246 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "getTotalIn", "()I");
			global::java.util.zip.Deflater._getBytesRead28247 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "getBytesRead", "()J");
			global::java.util.zip.Deflater._getTotalOut28248 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "getTotalOut", "()I");
			global::java.util.zip.Deflater._setLevel28249 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "setLevel", "(I)V");
			global::java.util.zip.Deflater._finish28250 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "finish", "()V");
			global::java.util.zip.Deflater._deflate28251 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "deflate", "([BII)I");
			global::java.util.zip.Deflater._deflate28252 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "deflate", "([B)I");
			global::java.util.zip.Deflater._setStrategy28253 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "setStrategy", "(I)V");
			global::java.util.zip.Deflater._Deflater28254 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "<init>", "(IZ)V");
			global::java.util.zip.Deflater._Deflater28255 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "<init>", "(I)V");
			global::java.util.zip.Deflater._Deflater28256 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "<init>", "()V");
		}
	}
}
