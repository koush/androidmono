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
		internal static global::MonoJavaBridge.MethodId _next25279;
		public int next() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.CollationElementIterator._next25279);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.CollationElementIterator.staticClass, global::java.text.CollationElementIterator._next25279);
		}
		internal static global::MonoJavaBridge.MethodId _previous25280;
		public int previous() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.CollationElementIterator._previous25280);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.CollationElementIterator.staticClass, global::java.text.CollationElementIterator._previous25280);
		}
		internal static global::MonoJavaBridge.MethodId _reset25281;
		public void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.CollationElementIterator._reset25281);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.CollationElementIterator.staticClass, global::java.text.CollationElementIterator._reset25281);
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
		internal static global::MonoJavaBridge.MethodId _getOffset25282;
		public int getOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.CollationElementIterator._getOffset25282);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.CollationElementIterator.staticClass, global::java.text.CollationElementIterator._getOffset25282);
		}
		internal static global::MonoJavaBridge.MethodId _setOffset25283;
		public void setOffset(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.CollationElementIterator._setOffset25283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.CollationElementIterator.staticClass, global::java.text.CollationElementIterator._setOffset25283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setText25284;
		public void setText(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.CollationElementIterator._setText25284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.CollationElementIterator.staticClass, global::java.text.CollationElementIterator._setText25284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setText25285;
		public void setText(java.text.CharacterIterator arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.CollationElementIterator._setText25285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.CollationElementIterator.staticClass, global::java.text.CollationElementIterator._setText25285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _primaryOrder25286;
		public static int primaryOrder(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.text.CollationElementIterator.staticClass, global::java.text.CollationElementIterator._primaryOrder25286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _secondaryOrder25287;
		public static short secondaryOrder(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticShortMethod(java.text.CollationElementIterator.staticClass, global::java.text.CollationElementIterator._secondaryOrder25287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _tertiaryOrder25288;
		public static short tertiaryOrder(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticShortMethod(java.text.CollationElementIterator.staticClass, global::java.text.CollationElementIterator._tertiaryOrder25288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMaxExpansion25289;
		public int getMaxExpansion(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.CollationElementIterator._getMaxExpansion25289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.CollationElementIterator.staticClass, global::java.text.CollationElementIterator._getMaxExpansion25289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::java.text.CollationElementIterator._next25279 = @__env.GetMethodIDNoThrow(global::java.text.CollationElementIterator.staticClass, "next", "()I");
			global::java.text.CollationElementIterator._previous25280 = @__env.GetMethodIDNoThrow(global::java.text.CollationElementIterator.staticClass, "previous", "()I");
			global::java.text.CollationElementIterator._reset25281 = @__env.GetMethodIDNoThrow(global::java.text.CollationElementIterator.staticClass, "reset", "()V");
			global::java.text.CollationElementIterator._getOffset25282 = @__env.GetMethodIDNoThrow(global::java.text.CollationElementIterator.staticClass, "getOffset", "()I");
			global::java.text.CollationElementIterator._setOffset25283 = @__env.GetMethodIDNoThrow(global::java.text.CollationElementIterator.staticClass, "setOffset", "(I)V");
			global::java.text.CollationElementIterator._setText25284 = @__env.GetMethodIDNoThrow(global::java.text.CollationElementIterator.staticClass, "setText", "(Ljava/lang/String;)V");
			global::java.text.CollationElementIterator._setText25285 = @__env.GetMethodIDNoThrow(global::java.text.CollationElementIterator.staticClass, "setText", "(Ljava/text/CharacterIterator;)V");
			global::java.text.CollationElementIterator._primaryOrder25286 = @__env.GetStaticMethodIDNoThrow(global::java.text.CollationElementIterator.staticClass, "primaryOrder", "(I)I");
			global::java.text.CollationElementIterator._secondaryOrder25287 = @__env.GetStaticMethodIDNoThrow(global::java.text.CollationElementIterator.staticClass, "secondaryOrder", "(I)S");
			global::java.text.CollationElementIterator._tertiaryOrder25288 = @__env.GetStaticMethodIDNoThrow(global::java.text.CollationElementIterator.staticClass, "tertiaryOrder", "(I)S");
			global::java.text.CollationElementIterator._getMaxExpansion25289 = @__env.GetMethodIDNoThrow(global::java.text.CollationElementIterator.staticClass, "getMaxExpansion", "(I)I");
		}
	}
}
