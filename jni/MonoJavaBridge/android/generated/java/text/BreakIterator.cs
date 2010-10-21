namespace java.text
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.text.BreakIterator_))]
	public abstract partial class BreakIterator : java.lang.Object, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BreakIterator()
		{
			InitJNI();
		}
		protected BreakIterator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone25102;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.BreakIterator._clone25102)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.BreakIterator.staticClass, global::java.text.BreakIterator._clone25102)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _next25103;
		public abstract int next();
		internal static global::MonoJavaBridge.MethodId _next25104;
		public abstract int next(int arg0);
		internal static global::MonoJavaBridge.MethodId _previous25105;
		public abstract int previous();
		internal static global::MonoJavaBridge.MethodId _getAvailableLocales25106;
		public static global::java.util.Locale[] getAvailableLocales() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.util.Locale>(@__env.CallStaticObjectMethod(java.text.BreakIterator.staticClass, global::java.text.BreakIterator._getAvailableLocales25106)) as java.util.Locale[];
		}
		internal static global::MonoJavaBridge.MethodId _current25107;
		public abstract int current();
		internal static global::MonoJavaBridge.MethodId _setText25108;
		public virtual void setText(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.BreakIterator._setText25108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.BreakIterator.staticClass, global::java.text.BreakIterator._setText25108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setText25109;
		public abstract void setText(java.text.CharacterIterator arg0);
		internal static global::MonoJavaBridge.MethodId _last25110;
		public abstract int last();
		internal static global::MonoJavaBridge.MethodId _first25111;
		public abstract int first();
		internal static global::MonoJavaBridge.MethodId _getText25112;
		public abstract global::java.text.CharacterIterator getText();
		internal static global::MonoJavaBridge.MethodId _following25113;
		public abstract int following(int arg0);
		internal static global::MonoJavaBridge.MethodId _preceding25114;
		public virtual int preceding(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.BreakIterator._preceding25114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.BreakIterator.staticClass, global::java.text.BreakIterator._preceding25114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isBoundary25115;
		public virtual bool isBoundary(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.BreakIterator._isBoundary25115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.BreakIterator.staticClass, global::java.text.BreakIterator._isBoundary25115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWordInstance25116;
		public static global::java.text.BreakIterator getWordInstance(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.BreakIterator.staticClass, global::java.text.BreakIterator._getWordInstance25116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.BreakIterator;
		}
		internal static global::MonoJavaBridge.MethodId _getWordInstance25117;
		public static global::java.text.BreakIterator getWordInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.BreakIterator.staticClass, global::java.text.BreakIterator._getWordInstance25117)) as java.text.BreakIterator;
		}
		internal static global::MonoJavaBridge.MethodId _getLineInstance25118;
		public static global::java.text.BreakIterator getLineInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.BreakIterator.staticClass, global::java.text.BreakIterator._getLineInstance25118)) as java.text.BreakIterator;
		}
		internal static global::MonoJavaBridge.MethodId _getLineInstance25119;
		public static global::java.text.BreakIterator getLineInstance(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.BreakIterator.staticClass, global::java.text.BreakIterator._getLineInstance25119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.BreakIterator;
		}
		internal static global::MonoJavaBridge.MethodId _getCharacterInstance25120;
		public static global::java.text.BreakIterator getCharacterInstance(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.BreakIterator.staticClass, global::java.text.BreakIterator._getCharacterInstance25120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.BreakIterator;
		}
		internal static global::MonoJavaBridge.MethodId _getCharacterInstance25121;
		public static global::java.text.BreakIterator getCharacterInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.BreakIterator.staticClass, global::java.text.BreakIterator._getCharacterInstance25121)) as java.text.BreakIterator;
		}
		internal static global::MonoJavaBridge.MethodId _getSentenceInstance25122;
		public static global::java.text.BreakIterator getSentenceInstance(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.BreakIterator.staticClass, global::java.text.BreakIterator._getSentenceInstance25122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.BreakIterator;
		}
		internal static global::MonoJavaBridge.MethodId _getSentenceInstance25123;
		public static global::java.text.BreakIterator getSentenceInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.BreakIterator.staticClass, global::java.text.BreakIterator._getSentenceInstance25123)) as java.text.BreakIterator;
		}
		internal static global::MonoJavaBridge.MethodId _BreakIterator25124;
		protected BreakIterator()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.BreakIterator.staticClass, global::java.text.BreakIterator._BreakIterator25124);
			Init(@__env, handle);
		}
		public static int DONE
		{
			get
			{
				return -1;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.BreakIterator.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/BreakIterator"));
			global::java.text.BreakIterator._clone25102 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.text.BreakIterator._next25103 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "next", "()I");
			global::java.text.BreakIterator._next25104 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "next", "(I)I");
			global::java.text.BreakIterator._previous25105 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "previous", "()I");
			global::java.text.BreakIterator._getAvailableLocales25106 = @__env.GetStaticMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "getAvailableLocales", "()[Ljava/util/Locale;");
			global::java.text.BreakIterator._current25107 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "current", "()I");
			global::java.text.BreakIterator._setText25108 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "setText", "(Ljava/lang/String;)V");
			global::java.text.BreakIterator._setText25109 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "setText", "(Ljava/text/CharacterIterator;)V");
			global::java.text.BreakIterator._last25110 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "last", "()I");
			global::java.text.BreakIterator._first25111 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "first", "()I");
			global::java.text.BreakIterator._getText25112 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "getText", "()Ljava/text/CharacterIterator;");
			global::java.text.BreakIterator._following25113 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "following", "(I)I");
			global::java.text.BreakIterator._preceding25114 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "preceding", "(I)I");
			global::java.text.BreakIterator._isBoundary25115 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "isBoundary", "(I)Z");
			global::java.text.BreakIterator._getWordInstance25116 = @__env.GetStaticMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "getWordInstance", "(Ljava/util/Locale;)Ljava/text/BreakIterator;");
			global::java.text.BreakIterator._getWordInstance25117 = @__env.GetStaticMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "getWordInstance", "()Ljava/text/BreakIterator;");
			global::java.text.BreakIterator._getLineInstance25118 = @__env.GetStaticMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "getLineInstance", "()Ljava/text/BreakIterator;");
			global::java.text.BreakIterator._getLineInstance25119 = @__env.GetStaticMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "getLineInstance", "(Ljava/util/Locale;)Ljava/text/BreakIterator;");
			global::java.text.BreakIterator._getCharacterInstance25120 = @__env.GetStaticMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "getCharacterInstance", "(Ljava/util/Locale;)Ljava/text/BreakIterator;");
			global::java.text.BreakIterator._getCharacterInstance25121 = @__env.GetStaticMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "getCharacterInstance", "()Ljava/text/BreakIterator;");
			global::java.text.BreakIterator._getSentenceInstance25122 = @__env.GetStaticMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "getSentenceInstance", "(Ljava/util/Locale;)Ljava/text/BreakIterator;");
			global::java.text.BreakIterator._getSentenceInstance25123 = @__env.GetStaticMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "getSentenceInstance", "()Ljava/text/BreakIterator;");
			global::java.text.BreakIterator._BreakIterator25124 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.text.BreakIterator))]
	public sealed partial class BreakIterator_ : java.text.BreakIterator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BreakIterator_()
		{
			InitJNI();
		}
		internal BreakIterator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _next25126;
		public override int next() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.BreakIterator_._next25126);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.BreakIterator_.staticClass, global::java.text.BreakIterator_._next25126);
		}
		internal static global::MonoJavaBridge.MethodId _next25127;
		public override int next(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.BreakIterator_._next25127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.BreakIterator_.staticClass, global::java.text.BreakIterator_._next25127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _previous25128;
		public override int previous() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.BreakIterator_._previous25128);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.BreakIterator_.staticClass, global::java.text.BreakIterator_._previous25128);
		}
		internal static global::MonoJavaBridge.MethodId _current25129;
		public override int current() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.BreakIterator_._current25129);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.BreakIterator_.staticClass, global::java.text.BreakIterator_._current25129);
		}
		internal static global::MonoJavaBridge.MethodId _setText25130;
		public override void setText(java.text.CharacterIterator arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.BreakIterator_._setText25130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.BreakIterator_.staticClass, global::java.text.BreakIterator_._setText25130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _last25131;
		public override int last() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.BreakIterator_._last25131);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.BreakIterator_.staticClass, global::java.text.BreakIterator_._last25131);
		}
		internal static global::MonoJavaBridge.MethodId _first25132;
		public override int first() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.BreakIterator_._first25132);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.BreakIterator_.staticClass, global::java.text.BreakIterator_._first25132);
		}
		internal static global::MonoJavaBridge.MethodId _getText25133;
		public override global::java.text.CharacterIterator getText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.text.CharacterIterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.BreakIterator_._getText25133)) as java.text.CharacterIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.text.CharacterIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.BreakIterator_.staticClass, global::java.text.BreakIterator_._getText25133)) as java.text.CharacterIterator;
		}
		internal static global::MonoJavaBridge.MethodId _following25134;
		public override int following(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.BreakIterator_._following25134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.BreakIterator_.staticClass, global::java.text.BreakIterator_._following25134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.BreakIterator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/BreakIterator"));
			global::java.text.BreakIterator_._next25126 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator_.staticClass, "next", "()I");
			global::java.text.BreakIterator_._next25127 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator_.staticClass, "next", "(I)I");
			global::java.text.BreakIterator_._previous25128 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator_.staticClass, "previous", "()I");
			global::java.text.BreakIterator_._current25129 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator_.staticClass, "current", "()I");
			global::java.text.BreakIterator_._setText25130 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator_.staticClass, "setText", "(Ljava/text/CharacterIterator;)V");
			global::java.text.BreakIterator_._last25131 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator_.staticClass, "last", "()I");
			global::java.text.BreakIterator_._first25132 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator_.staticClass, "first", "()I");
			global::java.text.BreakIterator_._getText25133 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator_.staticClass, "getText", "()Ljava/text/CharacterIterator;");
			global::java.text.BreakIterator_._following25134 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator_.staticClass, "following", "(I)I");
		}
	}
}
