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
		internal static global::MonoJavaBridge.MethodId _toString13957;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.StreamTokenizer._toString13957)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._toString13957)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _nextToken13958;
		public virtual int nextToken() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.StreamTokenizer._nextToken13958);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._nextToken13958);
		}
		internal static global::MonoJavaBridge.MethodId _pushBack13959;
		public virtual void pushBack() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer._pushBack13959);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._pushBack13959);
		}
		internal static global::MonoJavaBridge.MethodId _resetSyntax13960;
		public virtual void resetSyntax() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer._resetSyntax13960);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._resetSyntax13960);
		}
		internal static global::MonoJavaBridge.MethodId _wordChars13961;
		public virtual void wordChars(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer._wordChars13961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._wordChars13961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _whitespaceChars13962;
		public virtual void whitespaceChars(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer._whitespaceChars13962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._whitespaceChars13962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ordinaryChars13963;
		public virtual void ordinaryChars(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer._ordinaryChars13963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._ordinaryChars13963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ordinaryChar13964;
		public virtual void ordinaryChar(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer._ordinaryChar13964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._ordinaryChar13964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _commentChar13965;
		public virtual void commentChar(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer._commentChar13965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._commentChar13965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _quoteChar13966;
		public virtual void quoteChar(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer._quoteChar13966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._quoteChar13966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parseNumbers13967;
		public virtual void parseNumbers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer._parseNumbers13967);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._parseNumbers13967);
		}
		internal static global::MonoJavaBridge.MethodId _eolIsSignificant13968;
		public virtual void eolIsSignificant(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer._eolIsSignificant13968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._eolIsSignificant13968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _slashStarComments13969;
		public virtual void slashStarComments(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer._slashStarComments13969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._slashStarComments13969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _slashSlashComments13970;
		public virtual void slashSlashComments(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer._slashSlashComments13970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._slashSlashComments13970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lowerCaseMode13971;
		public virtual void lowerCaseMode(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer._lowerCaseMode13971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._lowerCaseMode13971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lineno13972;
		public virtual int lineno() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.StreamTokenizer._lineno13972);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._lineno13972);
		}
		internal static global::MonoJavaBridge.MethodId _StreamTokenizer13973;
		public StreamTokenizer(java.io.InputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._StreamTokenizer13973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StreamTokenizer13974;
		public StreamTokenizer(java.io.Reader arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._StreamTokenizer13974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _ttype13975;
		public int ttype
		{
			get
			{
				return default(int);
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
		internal static global::MonoJavaBridge.FieldId _sval13976;
		public global::java.lang.String sval
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _nval13977;
		public double nval
		{
			get
			{
				return default(double);
			}
			set
			{
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.StreamTokenizer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/StreamTokenizer"));
			global::java.io.StreamTokenizer._toString13957 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "toString", "()Ljava/lang/String;");
			global::java.io.StreamTokenizer._nextToken13958 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "nextToken", "()I");
			global::java.io.StreamTokenizer._pushBack13959 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "pushBack", "()V");
			global::java.io.StreamTokenizer._resetSyntax13960 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "resetSyntax", "()V");
			global::java.io.StreamTokenizer._wordChars13961 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "wordChars", "(II)V");
			global::java.io.StreamTokenizer._whitespaceChars13962 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "whitespaceChars", "(II)V");
			global::java.io.StreamTokenizer._ordinaryChars13963 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "ordinaryChars", "(II)V");
			global::java.io.StreamTokenizer._ordinaryChar13964 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "ordinaryChar", "(I)V");
			global::java.io.StreamTokenizer._commentChar13965 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "commentChar", "(I)V");
			global::java.io.StreamTokenizer._quoteChar13966 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "quoteChar", "(I)V");
			global::java.io.StreamTokenizer._parseNumbers13967 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "parseNumbers", "()V");
			global::java.io.StreamTokenizer._eolIsSignificant13968 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "eolIsSignificant", "(Z)V");
			global::java.io.StreamTokenizer._slashStarComments13969 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "slashStarComments", "(Z)V");
			global::java.io.StreamTokenizer._slashSlashComments13970 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "slashSlashComments", "(Z)V");
			global::java.io.StreamTokenizer._lowerCaseMode13971 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "lowerCaseMode", "(Z)V");
			global::java.io.StreamTokenizer._lineno13972 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "lineno", "()I");
			global::java.io.StreamTokenizer._StreamTokenizer13973 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::java.io.StreamTokenizer._StreamTokenizer13974 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "<init>", "(Ljava/io/Reader;)V");
		}
	}
}
