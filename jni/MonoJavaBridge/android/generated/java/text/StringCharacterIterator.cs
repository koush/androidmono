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
		internal static global::MonoJavaBridge.MethodId _equals19753;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.StringCharacterIterator._equals19753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._equals19753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode19754;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.StringCharacterIterator._hashCode19754);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._hashCode19754);
		}
		internal static global::MonoJavaBridge.MethodId _clone19755;
		public global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.StringCharacterIterator._clone19755)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._clone19755)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _next19756;
		public char next() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.StringCharacterIterator._next19756);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._next19756);
		}
		internal static global::MonoJavaBridge.MethodId _previous19757;
		public char previous() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.StringCharacterIterator._previous19757);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._previous19757);
		}
		public new int Index
		{
			get
			{
				return getIndex();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIndex19758;
		public int getIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.StringCharacterIterator._getIndex19758);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._getIndex19758);
		}
		internal static global::MonoJavaBridge.MethodId _current19759;
		public char current() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.StringCharacterIterator._current19759);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._current19759);
		}
		internal static global::MonoJavaBridge.MethodId _setIndex19760;
		public char setIndex(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.StringCharacterIterator._setIndex19760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._setIndex19760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int BeginIndex
		{
			get
			{
				return getBeginIndex();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBeginIndex19761;
		public int getBeginIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.StringCharacterIterator._getBeginIndex19761);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._getBeginIndex19761);
		}
		public new int EndIndex
		{
			get
			{
				return getEndIndex();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEndIndex19762;
		public int getEndIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.StringCharacterIterator._getEndIndex19762);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._getEndIndex19762);
		}
		internal static global::MonoJavaBridge.MethodId _setText19763;
		public void setText(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.StringCharacterIterator._setText19763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._setText19763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _last19764;
		public char last() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.StringCharacterIterator._last19764);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._last19764);
		}
		internal static global::MonoJavaBridge.MethodId _first19765;
		public char first() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.StringCharacterIterator._first19765);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._first19765);
		}
		internal static global::MonoJavaBridge.MethodId _StringCharacterIterator19766;
		public StringCharacterIterator(java.lang.String arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._StringCharacterIterator19766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StringCharacterIterator19767;
		public StringCharacterIterator(java.lang.String arg0, int arg1, int arg2, int arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._StringCharacterIterator19767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StringCharacterIterator19768;
		public StringCharacterIterator(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._StringCharacterIterator19768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.StringCharacterIterator.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/StringCharacterIterator"));
			global::java.text.StringCharacterIterator._equals19753 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.text.StringCharacterIterator._hashCode19754 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "hashCode", "()I");
			global::java.text.StringCharacterIterator._clone19755 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.text.StringCharacterIterator._next19756 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "next", "()C");
			global::java.text.StringCharacterIterator._previous19757 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "previous", "()C");
			global::java.text.StringCharacterIterator._getIndex19758 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "getIndex", "()I");
			global::java.text.StringCharacterIterator._current19759 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "current", "()C");
			global::java.text.StringCharacterIterator._setIndex19760 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "setIndex", "(I)C");
			global::java.text.StringCharacterIterator._getBeginIndex19761 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "getBeginIndex", "()I");
			global::java.text.StringCharacterIterator._getEndIndex19762 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "getEndIndex", "()I");
			global::java.text.StringCharacterIterator._setText19763 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "setText", "(Ljava/lang/String;)V");
			global::java.text.StringCharacterIterator._last19764 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "last", "()C");
			global::java.text.StringCharacterIterator._first19765 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "first", "()C");
			global::java.text.StringCharacterIterator._StringCharacterIterator19766 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::java.text.StringCharacterIterator._StringCharacterIterator19767 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "<init>", "(Ljava/lang/String;III)V");
			global::java.text.StringCharacterIterator._StringCharacterIterator19768 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
