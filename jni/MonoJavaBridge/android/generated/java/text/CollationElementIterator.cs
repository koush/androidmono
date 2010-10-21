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
		internal static global::MonoJavaBridge.MethodId _next25161;
		public int next() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.CollationElementIterator._next25161);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.CollationElementIterator.staticClass, global::java.text.CollationElementIterator._next25161);
		}
		internal static global::MonoJavaBridge.MethodId _previous25162;
		public int previous() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.CollationElementIterator._previous25162);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.CollationElementIterator.staticClass, global::java.text.CollationElementIterator._previous25162);
		}
		internal static global::MonoJavaBridge.MethodId _reset25163;
		public void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.CollationElementIterator._reset25163);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.CollationElementIterator.staticClass, global::java.text.CollationElementIterator._reset25163);
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
		internal static global::MonoJavaBridge.MethodId _getOffset25164;
		public int getOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.CollationElementIterator._getOffset25164);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.CollationElementIterator.staticClass, global::java.text.CollationElementIterator._getOffset25164);
		}
		internal static global::MonoJavaBridge.MethodId _setOffset25165;
		public void setOffset(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.CollationElementIterator._setOffset25165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.CollationElementIterator.staticClass, global::java.text.CollationElementIterator._setOffset25165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setText25166;
		public void setText(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.CollationElementIterator._setText25166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.CollationElementIterator.staticClass, global::java.text.CollationElementIterator._setText25166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setText25167;
		public void setText(java.text.CharacterIterator arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.CollationElementIterator._setText25167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.CollationElementIterator.staticClass, global::java.text.CollationElementIterator._setText25167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _primaryOrder25168;
		public static int primaryOrder(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.text.CollationElementIterator.staticClass, global::java.text.CollationElementIterator._primaryOrder25168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _secondaryOrder25169;
		public static short secondaryOrder(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticShortMethod(java.text.CollationElementIterator.staticClass, global::java.text.CollationElementIterator._secondaryOrder25169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _tertiaryOrder25170;
		public static short tertiaryOrder(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticShortMethod(java.text.CollationElementIterator.staticClass, global::java.text.CollationElementIterator._tertiaryOrder25170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMaxExpansion25171;
		public int getMaxExpansion(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.CollationElementIterator._getMaxExpansion25171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.CollationElementIterator.staticClass, global::java.text.CollationElementIterator._getMaxExpansion25171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::java.text.CollationElementIterator._next25161 = @__env.GetMethodIDNoThrow(global::java.text.CollationElementIterator.staticClass, "next", "()I");
			global::java.text.CollationElementIterator._previous25162 = @__env.GetMethodIDNoThrow(global::java.text.CollationElementIterator.staticClass, "previous", "()I");
			global::java.text.CollationElementIterator._reset25163 = @__env.GetMethodIDNoThrow(global::java.text.CollationElementIterator.staticClass, "reset", "()V");
			global::java.text.CollationElementIterator._getOffset25164 = @__env.GetMethodIDNoThrow(global::java.text.CollationElementIterator.staticClass, "getOffset", "()I");
			global::java.text.CollationElementIterator._setOffset25165 = @__env.GetMethodIDNoThrow(global::java.text.CollationElementIterator.staticClass, "setOffset", "(I)V");
			global::java.text.CollationElementIterator._setText25166 = @__env.GetMethodIDNoThrow(global::java.text.CollationElementIterator.staticClass, "setText", "(Ljava/lang/String;)V");
			global::java.text.CollationElementIterator._setText25167 = @__env.GetMethodIDNoThrow(global::java.text.CollationElementIterator.staticClass, "setText", "(Ljava/text/CharacterIterator;)V");
			global::java.text.CollationElementIterator._primaryOrder25168 = @__env.GetStaticMethodIDNoThrow(global::java.text.CollationElementIterator.staticClass, "primaryOrder", "(I)I");
			global::java.text.CollationElementIterator._secondaryOrder25169 = @__env.GetStaticMethodIDNoThrow(global::java.text.CollationElementIterator.staticClass, "secondaryOrder", "(I)S");
			global::java.text.CollationElementIterator._tertiaryOrder25170 = @__env.GetStaticMethodIDNoThrow(global::java.text.CollationElementIterator.staticClass, "tertiaryOrder", "(I)S");
			global::java.text.CollationElementIterator._getMaxExpansion25171 = @__env.GetMethodIDNoThrow(global::java.text.CollationElementIterator.staticClass, "getMaxExpansion", "(I)I");
		}
	}
}
