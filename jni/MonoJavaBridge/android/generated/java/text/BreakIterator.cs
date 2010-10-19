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
		internal static global::MonoJavaBridge.MethodId _clone19360;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.BreakIterator._clone19360)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.BreakIterator.staticClass, global::java.text.BreakIterator._clone19360)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _next19361;
		public abstract int next();
		internal static global::MonoJavaBridge.MethodId _next19362;
		public abstract int next(int arg0);
		internal static global::MonoJavaBridge.MethodId _previous19363;
		public abstract int previous();
		internal static global::MonoJavaBridge.MethodId _getAvailableLocales19364;
		public static global::java.util.Locale[] getAvailableLocales() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.util.Locale>(@__env.CallStaticObjectMethod(java.text.BreakIterator.staticClass, global::java.text.BreakIterator._getAvailableLocales19364)) as java.util.Locale[];
		}
		internal static global::MonoJavaBridge.MethodId _current19365;
		public abstract int current();
		internal static global::MonoJavaBridge.MethodId _setText19366;
		public virtual void setText(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.BreakIterator._setText19366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.BreakIterator.staticClass, global::java.text.BreakIterator._setText19366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setText19367;
		public abstract void setText(java.text.CharacterIterator arg0);
		internal static global::MonoJavaBridge.MethodId _last19368;
		public abstract int last();
		internal static global::MonoJavaBridge.MethodId _first19369;
		public abstract int first();
		internal static global::MonoJavaBridge.MethodId _getText19370;
		public abstract global::java.text.CharacterIterator getText();
		internal static global::MonoJavaBridge.MethodId _following19371;
		public abstract int following(int arg0);
		internal static global::MonoJavaBridge.MethodId _preceding19372;
		public virtual int preceding(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.BreakIterator._preceding19372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.BreakIterator.staticClass, global::java.text.BreakIterator._preceding19372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isBoundary19373;
		public virtual bool isBoundary(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.BreakIterator._isBoundary19373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.BreakIterator.staticClass, global::java.text.BreakIterator._isBoundary19373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWordInstance19374;
		public static global::java.text.BreakIterator getWordInstance(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.BreakIterator.staticClass, global::java.text.BreakIterator._getWordInstance19374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.BreakIterator;
		}
		internal static global::MonoJavaBridge.MethodId _getWordInstance19375;
		public static global::java.text.BreakIterator getWordInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.BreakIterator.staticClass, global::java.text.BreakIterator._getWordInstance19375)) as java.text.BreakIterator;
		}
		internal static global::MonoJavaBridge.MethodId _getLineInstance19376;
		public static global::java.text.BreakIterator getLineInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.BreakIterator.staticClass, global::java.text.BreakIterator._getLineInstance19376)) as java.text.BreakIterator;
		}
		internal static global::MonoJavaBridge.MethodId _getLineInstance19377;
		public static global::java.text.BreakIterator getLineInstance(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.BreakIterator.staticClass, global::java.text.BreakIterator._getLineInstance19377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.BreakIterator;
		}
		internal static global::MonoJavaBridge.MethodId _getCharacterInstance19378;
		public static global::java.text.BreakIterator getCharacterInstance(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.BreakIterator.staticClass, global::java.text.BreakIterator._getCharacterInstance19378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.BreakIterator;
		}
		internal static global::MonoJavaBridge.MethodId _getCharacterInstance19379;
		public static global::java.text.BreakIterator getCharacterInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.BreakIterator.staticClass, global::java.text.BreakIterator._getCharacterInstance19379)) as java.text.BreakIterator;
		}
		internal static global::MonoJavaBridge.MethodId _getSentenceInstance19380;
		public static global::java.text.BreakIterator getSentenceInstance(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.BreakIterator.staticClass, global::java.text.BreakIterator._getSentenceInstance19380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.BreakIterator;
		}
		internal static global::MonoJavaBridge.MethodId _getSentenceInstance19381;
		public static global::java.text.BreakIterator getSentenceInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.BreakIterator.staticClass, global::java.text.BreakIterator._getSentenceInstance19381)) as java.text.BreakIterator;
		}
		internal static global::MonoJavaBridge.MethodId _BreakIterator19382;
		protected BreakIterator()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.BreakIterator.staticClass, global::java.text.BreakIterator._BreakIterator19382);
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
			global::java.text.BreakIterator._clone19360 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.text.BreakIterator._next19361 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "next", "()I");
			global::java.text.BreakIterator._next19362 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "next", "(I)I");
			global::java.text.BreakIterator._previous19363 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "previous", "()I");
			global::java.text.BreakIterator._getAvailableLocales19364 = @__env.GetStaticMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "getAvailableLocales", "()[Ljava/util/Locale;");
			global::java.text.BreakIterator._current19365 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "current", "()I");
			global::java.text.BreakIterator._setText19366 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "setText", "(Ljava/lang/String;)V");
			global::java.text.BreakIterator._setText19367 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "setText", "(Ljava/text/CharacterIterator;)V");
			global::java.text.BreakIterator._last19368 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "last", "()I");
			global::java.text.BreakIterator._first19369 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "first", "()I");
			global::java.text.BreakIterator._getText19370 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "getText", "()Ljava/text/CharacterIterator;");
			global::java.text.BreakIterator._following19371 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "following", "(I)I");
			global::java.text.BreakIterator._preceding19372 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "preceding", "(I)I");
			global::java.text.BreakIterator._isBoundary19373 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "isBoundary", "(I)Z");
			global::java.text.BreakIterator._getWordInstance19374 = @__env.GetStaticMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "getWordInstance", "(Ljava/util/Locale;)Ljava/text/BreakIterator;");
			global::java.text.BreakIterator._getWordInstance19375 = @__env.GetStaticMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "getWordInstance", "()Ljava/text/BreakIterator;");
			global::java.text.BreakIterator._getLineInstance19376 = @__env.GetStaticMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "getLineInstance", "()Ljava/text/BreakIterator;");
			global::java.text.BreakIterator._getLineInstance19377 = @__env.GetStaticMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "getLineInstance", "(Ljava/util/Locale;)Ljava/text/BreakIterator;");
			global::java.text.BreakIterator._getCharacterInstance19378 = @__env.GetStaticMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "getCharacterInstance", "(Ljava/util/Locale;)Ljava/text/BreakIterator;");
			global::java.text.BreakIterator._getCharacterInstance19379 = @__env.GetStaticMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "getCharacterInstance", "()Ljava/text/BreakIterator;");
			global::java.text.BreakIterator._getSentenceInstance19380 = @__env.GetStaticMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "getSentenceInstance", "(Ljava/util/Locale;)Ljava/text/BreakIterator;");
			global::java.text.BreakIterator._getSentenceInstance19381 = @__env.GetStaticMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "getSentenceInstance", "()Ljava/text/BreakIterator;");
			global::java.text.BreakIterator._BreakIterator19382 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _next19383;
		public override int next() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.BreakIterator_._next19383);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.BreakIterator_.staticClass, global::java.text.BreakIterator_._next19383);
		}
		internal static global::MonoJavaBridge.MethodId _next19384;
		public override int next(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.BreakIterator_._next19384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.BreakIterator_.staticClass, global::java.text.BreakIterator_._next19384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _previous19385;
		public override int previous() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.BreakIterator_._previous19385);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.BreakIterator_.staticClass, global::java.text.BreakIterator_._previous19385);
		}
		internal static global::MonoJavaBridge.MethodId _current19386;
		public override int current() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.BreakIterator_._current19386);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.BreakIterator_.staticClass, global::java.text.BreakIterator_._current19386);
		}
		internal static global::MonoJavaBridge.MethodId _setText19387;
		public override void setText(java.text.CharacterIterator arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.BreakIterator_._setText19387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.BreakIterator_.staticClass, global::java.text.BreakIterator_._setText19387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _last19388;
		public override int last() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.BreakIterator_._last19388);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.BreakIterator_.staticClass, global::java.text.BreakIterator_._last19388);
		}
		internal static global::MonoJavaBridge.MethodId _first19389;
		public override int first() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.BreakIterator_._first19389);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.BreakIterator_.staticClass, global::java.text.BreakIterator_._first19389);
		}
		internal static global::MonoJavaBridge.MethodId _getText19390;
		public override global::java.text.CharacterIterator getText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.text.CharacterIterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.BreakIterator_._getText19390)) as java.text.CharacterIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.text.CharacterIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.BreakIterator_.staticClass, global::java.text.BreakIterator_._getText19390)) as java.text.CharacterIterator;
		}
		internal static global::MonoJavaBridge.MethodId _following19391;
		public override int following(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.BreakIterator_._following19391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.BreakIterator_.staticClass, global::java.text.BreakIterator_._following19391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.BreakIterator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/BreakIterator"));
			global::java.text.BreakIterator_._next19383 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator_.staticClass, "next", "()I");
			global::java.text.BreakIterator_._next19384 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator_.staticClass, "next", "(I)I");
			global::java.text.BreakIterator_._previous19385 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator_.staticClass, "previous", "()I");
			global::java.text.BreakIterator_._current19386 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator_.staticClass, "current", "()I");
			global::java.text.BreakIterator_._setText19387 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator_.staticClass, "setText", "(Ljava/text/CharacterIterator;)V");
			global::java.text.BreakIterator_._last19388 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator_.staticClass, "last", "()I");
			global::java.text.BreakIterator_._first19389 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator_.staticClass, "first", "()I");
			global::java.text.BreakIterator_._getText19390 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator_.staticClass, "getText", "()Ljava/text/CharacterIterator;");
			global::java.text.BreakIterator_._following19391 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator_.staticClass, "following", "(I)I");
		}
	}
}
