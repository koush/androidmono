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
		internal static global::MonoJavaBridge.MethodId _finalize22399;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Inflater._finalize22399);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._finalize22399);
		}
		internal static global::MonoJavaBridge.MethodId _reset22400;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Inflater._reset22400);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._reset22400);
		}
		internal static global::MonoJavaBridge.MethodId _finished22401;
		public virtual bool finished() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.zip.Inflater._finished22401);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._finished22401);
		}
		internal static global::MonoJavaBridge.MethodId _end22402;
		public virtual void end() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Inflater._end22402);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._end22402);
		}
		internal static global::MonoJavaBridge.MethodId _setInput22403;
		public virtual void setInput(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Inflater._setInput22403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._setInput22403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setInput22404;
		public virtual void setInput(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Inflater._setInput22404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._setInput22404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long BytesWritten
		{
			get
			{
				return getBytesWritten();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBytesWritten22405;
		public virtual long getBytesWritten() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.zip.Inflater._getBytesWritten22405);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._getBytesWritten22405);
		}
		internal static global::MonoJavaBridge.MethodId _inflate22406;
		public virtual int inflate(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.Inflater._inflate22406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._inflate22406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _inflate22407;
		public virtual int inflate(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.Inflater._inflate22407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._inflate22407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _needsDictionary22408;
		public virtual bool needsDictionary() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.zip.Inflater._needsDictionary22408);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._needsDictionary22408);
		}
		internal static global::MonoJavaBridge.MethodId _needsInput22409;
		public virtual bool needsInput() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.zip.Inflater._needsInput22409);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._needsInput22409);
		}
		internal static global::MonoJavaBridge.MethodId _setDictionary22410;
		public virtual void setDictionary(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Inflater._setDictionary22410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._setDictionary22410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setDictionary22411;
		public virtual void setDictionary(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Inflater._setDictionary22411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._setDictionary22411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Remaining
		{
			get
			{
				return getRemaining();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRemaining22412;
		public virtual int getRemaining() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.Inflater._getRemaining22412);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._getRemaining22412);
		}
		public new int Adler
		{
			get
			{
				return getAdler();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAdler22413;
		public virtual int getAdler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.Inflater._getAdler22413);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._getAdler22413);
		}
		public new int TotalIn
		{
			get
			{
				return getTotalIn();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTotalIn22414;
		public virtual int getTotalIn() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.Inflater._getTotalIn22414);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._getTotalIn22414);
		}
		public new long BytesRead
		{
			get
			{
				return getBytesRead();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBytesRead22415;
		public virtual long getBytesRead() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.zip.Inflater._getBytesRead22415);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._getBytesRead22415);
		}
		public new int TotalOut
		{
			get
			{
				return getTotalOut();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTotalOut22416;
		public virtual int getTotalOut() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.Inflater._getTotalOut22416);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._getTotalOut22416);
		}
		internal static global::MonoJavaBridge.MethodId _Inflater22417;
		public Inflater(bool arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._Inflater22417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Inflater22418;
		public Inflater()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._Inflater22418);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.Inflater.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/Inflater"));
			global::java.util.zip.Inflater._finalize22399 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "finalize", "()V");
			global::java.util.zip.Inflater._reset22400 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "reset", "()V");
			global::java.util.zip.Inflater._finished22401 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "finished", "()Z");
			global::java.util.zip.Inflater._end22402 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "end", "()V");
			global::java.util.zip.Inflater._setInput22403 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "setInput", "([BII)V");
			global::java.util.zip.Inflater._setInput22404 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "setInput", "([B)V");
			global::java.util.zip.Inflater._getBytesWritten22405 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "getBytesWritten", "()J");
			global::java.util.zip.Inflater._inflate22406 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "inflate", "([B)I");
			global::java.util.zip.Inflater._inflate22407 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "inflate", "([BII)I");
			global::java.util.zip.Inflater._needsDictionary22408 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "needsDictionary", "()Z");
			global::java.util.zip.Inflater._needsInput22409 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "needsInput", "()Z");
			global::java.util.zip.Inflater._setDictionary22410 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "setDictionary", "([BII)V");
			global::java.util.zip.Inflater._setDictionary22411 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "setDictionary", "([B)V");
			global::java.util.zip.Inflater._getRemaining22412 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "getRemaining", "()I");
			global::java.util.zip.Inflater._getAdler22413 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "getAdler", "()I");
			global::java.util.zip.Inflater._getTotalIn22414 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "getTotalIn", "()I");
			global::java.util.zip.Inflater._getBytesRead22415 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "getBytesRead", "()J");
			global::java.util.zip.Inflater._getTotalOut22416 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "getTotalOut", "()I");
			global::java.util.zip.Inflater._Inflater22417 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "<init>", "(Z)V");
			global::java.util.zip.Inflater._Inflater22418 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "<init>", "()V");
		}
	}
}
