namespace java.util.zip
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Inflater : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Inflater()
		{
			InitJNI();
		}
		protected Inflater(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize28282;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Inflater._finalize28282);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._finalize28282);
		}
		internal static global::MonoJavaBridge.MethodId _reset28283;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Inflater._reset28283);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._reset28283);
		}
		internal static global::MonoJavaBridge.MethodId _finished28284;
		public virtual bool finished() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.zip.Inflater._finished28284);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._finished28284);
		}
		internal static global::MonoJavaBridge.MethodId _end28285;
		public virtual void end() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Inflater._end28285);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._end28285);
		}
		internal static global::MonoJavaBridge.MethodId _setInput28286;
		public virtual void setInput(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Inflater._setInput28286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._setInput28286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setInput28287;
		public virtual void setInput(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Inflater._setInput28287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._setInput28287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long BytesWritten
		{
			get
			{
				return getBytesWritten();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBytesWritten28288;
		public virtual long getBytesWritten() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.zip.Inflater._getBytesWritten28288);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._getBytesWritten28288);
		}
		internal static global::MonoJavaBridge.MethodId _inflate28289;
		public virtual int inflate(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.Inflater._inflate28289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._inflate28289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _inflate28290;
		public virtual int inflate(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.Inflater._inflate28290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._inflate28290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _needsDictionary28291;
		public virtual bool needsDictionary() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.zip.Inflater._needsDictionary28291);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._needsDictionary28291);
		}
		internal static global::MonoJavaBridge.MethodId _needsInput28292;
		public virtual bool needsInput() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.zip.Inflater._needsInput28292);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._needsInput28292);
		}
		internal static global::MonoJavaBridge.MethodId _setDictionary28293;
		public virtual void setDictionary(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Inflater._setDictionary28293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._setDictionary28293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setDictionary28294;
		public virtual void setDictionary(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Inflater._setDictionary28294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._setDictionary28294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Remaining
		{
			get
			{
				return getRemaining();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRemaining28295;
		public virtual int getRemaining() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.Inflater._getRemaining28295);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._getRemaining28295);
		}
		public new int Adler
		{
			get
			{
				return getAdler();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAdler28296;
		public virtual int getAdler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.Inflater._getAdler28296);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._getAdler28296);
		}
		public new int TotalIn
		{
			get
			{
				return getTotalIn();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTotalIn28297;
		public virtual int getTotalIn() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.Inflater._getTotalIn28297);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._getTotalIn28297);
		}
		public new long BytesRead
		{
			get
			{
				return getBytesRead();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBytesRead28298;
		public virtual long getBytesRead() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.zip.Inflater._getBytesRead28298);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._getBytesRead28298);
		}
		public new int TotalOut
		{
			get
			{
				return getTotalOut();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTotalOut28299;
		public virtual int getTotalOut() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.Inflater._getTotalOut28299);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._getTotalOut28299);
		}
		internal static global::MonoJavaBridge.MethodId _Inflater28300;
		public Inflater(bool arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._Inflater28300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Inflater28301;
		public Inflater()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._Inflater28301);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.Inflater.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/Inflater"));
			global::java.util.zip.Inflater._finalize28282 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "finalize", "()V");
			global::java.util.zip.Inflater._reset28283 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "reset", "()V");
			global::java.util.zip.Inflater._finished28284 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "finished", "()Z");
			global::java.util.zip.Inflater._end28285 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "end", "()V");
			global::java.util.zip.Inflater._setInput28286 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "setInput", "([BII)V");
			global::java.util.zip.Inflater._setInput28287 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "setInput", "([B)V");
			global::java.util.zip.Inflater._getBytesWritten28288 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "getBytesWritten", "()J");
			global::java.util.zip.Inflater._inflate28289 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "inflate", "([B)I");
			global::java.util.zip.Inflater._inflate28290 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "inflate", "([BII)I");
			global::java.util.zip.Inflater._needsDictionary28291 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "needsDictionary", "()Z");
			global::java.util.zip.Inflater._needsInput28292 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "needsInput", "()Z");
			global::java.util.zip.Inflater._setDictionary28293 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "setDictionary", "([BII)V");
			global::java.util.zip.Inflater._setDictionary28294 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "setDictionary", "([B)V");
			global::java.util.zip.Inflater._getRemaining28295 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "getRemaining", "()I");
			global::java.util.zip.Inflater._getAdler28296 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "getAdler", "()I");
			global::java.util.zip.Inflater._getTotalIn28297 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "getTotalIn", "()I");
			global::java.util.zip.Inflater._getBytesRead28298 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "getBytesRead", "()J");
			global::java.util.zip.Inflater._getTotalOut28299 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "getTotalOut", "()I");
			global::java.util.zip.Inflater._Inflater28300 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "<init>", "(Z)V");
			global::java.util.zip.Inflater._Inflater28301 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "<init>", "()V");
		}
	}
}
