namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StreamTokenizer : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static StreamTokenizer()
		{
			InitJNI();
		}
		protected StreamTokenizer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString19459;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.StreamTokenizer._toString19459)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._toString19459)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _nextToken19460;
		public virtual int nextToken() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.StreamTokenizer._nextToken19460);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._nextToken19460);
		}
		internal static global::MonoJavaBridge.MethodId _pushBack19461;
		public virtual void pushBack() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer._pushBack19461);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._pushBack19461);
		}
		internal static global::MonoJavaBridge.MethodId _resetSyntax19462;
		public virtual void resetSyntax() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer._resetSyntax19462);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._resetSyntax19462);
		}
		internal static global::MonoJavaBridge.MethodId _wordChars19463;
		public virtual void wordChars(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer._wordChars19463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._wordChars19463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _whitespaceChars19464;
		public virtual void whitespaceChars(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer._whitespaceChars19464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._whitespaceChars19464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ordinaryChars19465;
		public virtual void ordinaryChars(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer._ordinaryChars19465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._ordinaryChars19465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ordinaryChar19466;
		public virtual void ordinaryChar(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer._ordinaryChar19466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._ordinaryChar19466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _commentChar19467;
		public virtual void commentChar(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer._commentChar19467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._commentChar19467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _quoteChar19468;
		public virtual void quoteChar(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer._quoteChar19468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._quoteChar19468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parseNumbers19469;
		public virtual void parseNumbers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer._parseNumbers19469);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._parseNumbers19469);
		}
		internal static global::MonoJavaBridge.MethodId _eolIsSignificant19470;
		public virtual void eolIsSignificant(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer._eolIsSignificant19470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._eolIsSignificant19470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _slashStarComments19471;
		public virtual void slashStarComments(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer._slashStarComments19471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._slashStarComments19471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _slashSlashComments19472;
		public virtual void slashSlashComments(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer._slashSlashComments19472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._slashSlashComments19472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lowerCaseMode19473;
		public virtual void lowerCaseMode(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer._lowerCaseMode19473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._lowerCaseMode19473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lineno19474;
		public virtual int lineno() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.StreamTokenizer._lineno19474);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._lineno19474);
		}
		internal static global::MonoJavaBridge.MethodId _StreamTokenizer19475;
		public StreamTokenizer(java.io.InputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._StreamTokenizer19475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StreamTokenizer19476;
		public StreamTokenizer(java.io.Reader arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._StreamTokenizer19476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _ttype19477;
		public int ttype
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _ttype19477);
			}
			set
			{
			}
		}
		public static int TT_EOF
		{
			get
			{
				return -1;
			}
		}
		public static int TT_EOL
		{
			get
			{
				return 10;
			}
		}
		public static int TT_NUMBER
		{
			get
			{
				return -2;
			}
		}
		public static int TT_WORD
		{
			get
			{
				return -3;
			}
		}
		internal static global::MonoJavaBridge.FieldId _sval19482;
		public global::java.lang.String sval
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _sval19482)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _nval19483;
		public double nval
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetDoubleField(this.JvmHandle, _nval19483);
			}
			set
			{
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.StreamTokenizer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/StreamTokenizer"));
			global::java.io.StreamTokenizer._toString19459 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "toString", "()Ljava/lang/String;");
			global::java.io.StreamTokenizer._nextToken19460 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "nextToken", "()I");
			global::java.io.StreamTokenizer._pushBack19461 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "pushBack", "()V");
			global::java.io.StreamTokenizer._resetSyntax19462 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "resetSyntax", "()V");
			global::java.io.StreamTokenizer._wordChars19463 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "wordChars", "(II)V");
			global::java.io.StreamTokenizer._whitespaceChars19464 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "whitespaceChars", "(II)V");
			global::java.io.StreamTokenizer._ordinaryChars19465 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "ordinaryChars", "(II)V");
			global::java.io.StreamTokenizer._ordinaryChar19466 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "ordinaryChar", "(I)V");
			global::java.io.StreamTokenizer._commentChar19467 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "commentChar", "(I)V");
			global::java.io.StreamTokenizer._quoteChar19468 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "quoteChar", "(I)V");
			global::java.io.StreamTokenizer._parseNumbers19469 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "parseNumbers", "()V");
			global::java.io.StreamTokenizer._eolIsSignificant19470 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "eolIsSignificant", "(Z)V");
			global::java.io.StreamTokenizer._slashStarComments19471 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "slashStarComments", "(Z)V");
			global::java.io.StreamTokenizer._slashSlashComments19472 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "slashSlashComments", "(Z)V");
			global::java.io.StreamTokenizer._lowerCaseMode19473 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "lowerCaseMode", "(Z)V");
			global::java.io.StreamTokenizer._lineno19474 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "lineno", "()I");
			global::java.io.StreamTokenizer._StreamTokenizer19475 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::java.io.StreamTokenizer._StreamTokenizer19476 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "<init>", "(Ljava/io/Reader;)V");
			global::java.io.StreamTokenizer._ttype19477 = @__env.GetFieldIDNoThrow(global::java.io.StreamTokenizer.staticClass, "ttype", "I");
			global::java.io.StreamTokenizer._sval19482 = @__env.GetFieldIDNoThrow(global::java.io.StreamTokenizer.staticClass, "sval", "Ljava/lang/String;");
			global::java.io.StreamTokenizer._nval19483 = @__env.GetFieldIDNoThrow(global::java.io.StreamTokenizer.staticClass, "nval", "D");
		}
	}
}
