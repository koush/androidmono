namespace java.text
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class StringCharacterIterator : java.lang.Object, CharacterIterator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static StringCharacterIterator()
		{
			InitJNI();
		}
		internal StringCharacterIterator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals25529;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.StringCharacterIterator._equals25529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._equals25529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25530;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.StringCharacterIterator._hashCode25530);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._hashCode25530);
		}
		internal static global::MonoJavaBridge.MethodId _clone25531;
		public global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.StringCharacterIterator._clone25531)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._clone25531)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _next25532;
		public char next() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.StringCharacterIterator._next25532);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._next25532);
		}
		internal static global::MonoJavaBridge.MethodId _previous25533;
		public char previous() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.StringCharacterIterator._previous25533);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._previous25533);
		}
		public new int Index
		{
			get
			{
				return getIndex();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIndex25534;
		public int getIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.StringCharacterIterator._getIndex25534);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._getIndex25534);
		}
		internal static global::MonoJavaBridge.MethodId _current25535;
		public char current() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.StringCharacterIterator._current25535);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._current25535);
		}
		internal static global::MonoJavaBridge.MethodId _setIndex25536;
		public char setIndex(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.StringCharacterIterator._setIndex25536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._setIndex25536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int BeginIndex
		{
			get
			{
				return getBeginIndex();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBeginIndex25537;
		public int getBeginIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.StringCharacterIterator._getBeginIndex25537);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._getBeginIndex25537);
		}
		public new int EndIndex
		{
			get
			{
				return getEndIndex();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEndIndex25538;
		public int getEndIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.StringCharacterIterator._getEndIndex25538);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._getEndIndex25538);
		}
		internal static global::MonoJavaBridge.MethodId _setText25539;
		public void setText(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.StringCharacterIterator._setText25539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._setText25539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _last25540;
		public char last() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.StringCharacterIterator._last25540);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._last25540);
		}
		internal static global::MonoJavaBridge.MethodId _first25541;
		public char first() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.StringCharacterIterator._first25541);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._first25541);
		}
		internal static global::MonoJavaBridge.MethodId _StringCharacterIterator25542;
		public StringCharacterIterator(java.lang.String arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._StringCharacterIterator25542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StringCharacterIterator25543;
		public StringCharacterIterator(java.lang.String arg0, int arg1, int arg2, int arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._StringCharacterIterator25543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StringCharacterIterator25544;
		public StringCharacterIterator(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._StringCharacterIterator25544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.StringCharacterIterator.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/StringCharacterIterator"));
			global::java.text.StringCharacterIterator._equals25529 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.text.StringCharacterIterator._hashCode25530 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "hashCode", "()I");
			global::java.text.StringCharacterIterator._clone25531 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.text.StringCharacterIterator._next25532 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "next", "()C");
			global::java.text.StringCharacterIterator._previous25533 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "previous", "()C");
			global::java.text.StringCharacterIterator._getIndex25534 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "getIndex", "()I");
			global::java.text.StringCharacterIterator._current25535 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "current", "()C");
			global::java.text.StringCharacterIterator._setIndex25536 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "setIndex", "(I)C");
			global::java.text.StringCharacterIterator._getBeginIndex25537 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "getBeginIndex", "()I");
			global::java.text.StringCharacterIterator._getEndIndex25538 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "getEndIndex", "()I");
			global::java.text.StringCharacterIterator._setText25539 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "setText", "(Ljava/lang/String;)V");
			global::java.text.StringCharacterIterator._last25540 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "last", "()C");
			global::java.text.StringCharacterIterator._first25541 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "first", "()C");
			global::java.text.StringCharacterIterator._StringCharacterIterator25542 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::java.text.StringCharacterIterator._StringCharacterIterator25543 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "<init>", "(Ljava/lang/String;III)V");
			global::java.text.StringCharacterIterator._StringCharacterIterator25544 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
