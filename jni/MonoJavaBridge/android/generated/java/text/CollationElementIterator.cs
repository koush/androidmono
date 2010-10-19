namespace java.text
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class CollationElementIterator : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CollationElementIterator()
		{
			InitJNI();
		}
		internal CollationElementIterator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _next19418;
		public int next() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.CollationElementIterator._next19418);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.CollationElementIterator.staticClass, global::java.text.CollationElementIterator._next19418);
		}
		internal static global::MonoJavaBridge.MethodId _previous19419;
		public int previous() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.CollationElementIterator._previous19419);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.CollationElementIterator.staticClass, global::java.text.CollationElementIterator._previous19419);
		}
		internal static global::MonoJavaBridge.MethodId _reset19420;
		public void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.CollationElementIterator._reset19420);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.CollationElementIterator.staticClass, global::java.text.CollationElementIterator._reset19420);
		}
		public new int Offset
		{
			get
			{
				return getOffset();
			}
			set
			{
				setOffset(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOffset19421;
		public int getOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.CollationElementIterator._getOffset19421);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.CollationElementIterator.staticClass, global::java.text.CollationElementIterator._getOffset19421);
		}
		internal static global::MonoJavaBridge.MethodId _setOffset19422;
		public void setOffset(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.CollationElementIterator._setOffset19422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.CollationElementIterator.staticClass, global::java.text.CollationElementIterator._setOffset19422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setText19423;
		public void setText(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.CollationElementIterator._setText19423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.CollationElementIterator.staticClass, global::java.text.CollationElementIterator._setText19423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setText19424;
		public void setText(java.text.CharacterIterator arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.CollationElementIterator._setText19424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.CollationElementIterator.staticClass, global::java.text.CollationElementIterator._setText19424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _primaryOrder19425;
		public static int primaryOrder(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.text.CollationElementIterator.staticClass, global::java.text.CollationElementIterator._primaryOrder19425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _secondaryOrder19426;
		public static short secondaryOrder(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticShortMethod(java.text.CollationElementIterator.staticClass, global::java.text.CollationElementIterator._secondaryOrder19426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _tertiaryOrder19427;
		public static short tertiaryOrder(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticShortMethod(java.text.CollationElementIterator.staticClass, global::java.text.CollationElementIterator._tertiaryOrder19427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMaxExpansion19428;
		public int getMaxExpansion(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.CollationElementIterator._getMaxExpansion19428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.CollationElementIterator.staticClass, global::java.text.CollationElementIterator._getMaxExpansion19428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static int NULLORDER
		{
			get
			{
				return -1;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.CollationElementIterator.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/CollationElementIterator"));
			global::java.text.CollationElementIterator._next19418 = @__env.GetMethodIDNoThrow(global::java.text.CollationElementIterator.staticClass, "next", "()I");
			global::java.text.CollationElementIterator._previous19419 = @__env.GetMethodIDNoThrow(global::java.text.CollationElementIterator.staticClass, "previous", "()I");
			global::java.text.CollationElementIterator._reset19420 = @__env.GetMethodIDNoThrow(global::java.text.CollationElementIterator.staticClass, "reset", "()V");
			global::java.text.CollationElementIterator._getOffset19421 = @__env.GetMethodIDNoThrow(global::java.text.CollationElementIterator.staticClass, "getOffset", "()I");
			global::java.text.CollationElementIterator._setOffset19422 = @__env.GetMethodIDNoThrow(global::java.text.CollationElementIterator.staticClass, "setOffset", "(I)V");
			global::java.text.CollationElementIterator._setText19423 = @__env.GetMethodIDNoThrow(global::java.text.CollationElementIterator.staticClass, "setText", "(Ljava/lang/String;)V");
			global::java.text.CollationElementIterator._setText19424 = @__env.GetMethodIDNoThrow(global::java.text.CollationElementIterator.staticClass, "setText", "(Ljava/text/CharacterIterator;)V");
			global::java.text.CollationElementIterator._primaryOrder19425 = @__env.GetStaticMethodIDNoThrow(global::java.text.CollationElementIterator.staticClass, "primaryOrder", "(I)I");
			global::java.text.CollationElementIterator._secondaryOrder19426 = @__env.GetStaticMethodIDNoThrow(global::java.text.CollationElementIterator.staticClass, "secondaryOrder", "(I)S");
			global::java.text.CollationElementIterator._tertiaryOrder19427 = @__env.GetStaticMethodIDNoThrow(global::java.text.CollationElementIterator.staticClass, "tertiaryOrder", "(I)S");
			global::java.text.CollationElementIterator._getMaxExpansion19428 = @__env.GetMethodIDNoThrow(global::java.text.CollationElementIterator.staticClass, "getMaxExpansion", "(I)I");
		}
	}
}
