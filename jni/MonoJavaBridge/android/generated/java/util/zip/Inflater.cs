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
		internal static global::MonoJavaBridge.MethodId _finalize28400;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Inflater._finalize28400);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._finalize28400);
		}
		internal static global::MonoJavaBridge.MethodId _reset28401;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Inflater._reset28401);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._reset28401);
		}
		internal static global::MonoJavaBridge.MethodId _finished28402;
		public virtual bool finished() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.zip.Inflater._finished28402);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._finished28402);
		}
		internal static global::MonoJavaBridge.MethodId _end28403;
		public virtual void end() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Inflater._end28403);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._end28403);
		}
		internal static global::MonoJavaBridge.MethodId _setInput28404;
		public virtual void setInput(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Inflater._setInput28404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._setInput28404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setInput28405;
		public virtual void setInput(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Inflater._setInput28405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._setInput28405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long BytesWritten
		{
			get
			{
				return getBytesWritten();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBytesWritten28406;
		public virtual long getBytesWritten() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.zip.Inflater._getBytesWritten28406);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._getBytesWritten28406);
		}
		internal static global::MonoJavaBridge.MethodId _inflate28407;
		public virtual int inflate(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.Inflater._inflate28407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._inflate28407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _inflate28408;
		public virtual int inflate(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.Inflater._inflate28408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._inflate28408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _needsDictionary28409;
		public virtual bool needsDictionary() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.zip.Inflater._needsDictionary28409);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._needsDictionary28409);
		}
		internal static global::MonoJavaBridge.MethodId _needsInput28410;
		public virtual bool needsInput() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.zip.Inflater._needsInput28410);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._needsInput28410);
		}
		internal static global::MonoJavaBridge.MethodId _setDictionary28411;
		public virtual void setDictionary(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Inflater._setDictionary28411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._setDictionary28411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setDictionary28412;
		public virtual void setDictionary(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Inflater._setDictionary28412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._setDictionary28412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Remaining
		{
			get
			{
				return getRemaining();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRemaining28413;
		public virtual int getRemaining() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.Inflater._getRemaining28413);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._getRemaining28413);
		}
		public new int Adler
		{
			get
			{
				return getAdler();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAdler28414;
		public virtual int getAdler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.Inflater._getAdler28414);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._getAdler28414);
		}
		public new int TotalIn
		{
			get
			{
				return getTotalIn();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTotalIn28415;
		public virtual int getTotalIn() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.Inflater._getTotalIn28415);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._getTotalIn28415);
		}
		public new long BytesRead
		{
			get
			{
				return getBytesRead();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBytesRead28416;
		public virtual long getBytesRead() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.zip.Inflater._getBytesRead28416);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._getBytesRead28416);
		}
		public new int TotalOut
		{
			get
			{
				return getTotalOut();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTotalOut28417;
		public virtual int getTotalOut() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.Inflater._getTotalOut28417);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._getTotalOut28417);
		}
		internal static global::MonoJavaBridge.MethodId _Inflater28418;
		public Inflater(bool arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._Inflater28418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Inflater28419;
		public Inflater()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.Inflater.staticClass, global::java.util.zip.Inflater._Inflater28419);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.Inflater.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/Inflater"));
			global::java.util.zip.Inflater._finalize28400 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "finalize", "()V");
			global::java.util.zip.Inflater._reset28401 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "reset", "()V");
			global::java.util.zip.Inflater._finished28402 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "finished", "()Z");
			global::java.util.zip.Inflater._end28403 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "end", "()V");
			global::java.util.zip.Inflater._setInput28404 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "setInput", "([BII)V");
			global::java.util.zip.Inflater._setInput28405 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "setInput", "([B)V");
			global::java.util.zip.Inflater._getBytesWritten28406 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "getBytesWritten", "()J");
			global::java.util.zip.Inflater._inflate28407 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "inflate", "([B)I");
			global::java.util.zip.Inflater._inflate28408 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "inflate", "([BII)I");
			global::java.util.zip.Inflater._needsDictionary28409 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "needsDictionary", "()Z");
			global::java.util.zip.Inflater._needsInput28410 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "needsInput", "()Z");
			global::java.util.zip.Inflater._setDictionary28411 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "setDictionary", "([BII)V");
			global::java.util.zip.Inflater._setDictionary28412 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "setDictionary", "([B)V");
			global::java.util.zip.Inflater._getRemaining28413 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "getRemaining", "()I");
			global::java.util.zip.Inflater._getAdler28414 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "getAdler", "()I");
			global::java.util.zip.Inflater._getTotalIn28415 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "getTotalIn", "()I");
			global::java.util.zip.Inflater._getBytesRead28416 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "getBytesRead", "()J");
			global::java.util.zip.Inflater._getTotalOut28417 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "getTotalOut", "()I");
			global::java.util.zip.Inflater._Inflater28418 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "<init>", "(Z)V");
			global::java.util.zip.Inflater._Inflater28419 = @__env.GetMethodIDNoThrow(global::java.util.zip.Inflater.staticClass, "<init>", "()V");
		}
	}
}
