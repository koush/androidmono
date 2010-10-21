namespace java.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AttributedString : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AttributedString()
		{
			InitJNI();
		}
		protected AttributedString(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.text.AttributedCharacterIterator Iterator
		{
			get
			{
				return getIterator();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIterator25069;
		public virtual global::java.text.AttributedCharacterIterator getIterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.text.AttributedCharacterIterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.AttributedString._getIterator25069)) as java.text.AttributedCharacterIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.text.AttributedCharacterIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.AttributedString.staticClass, global::java.text.AttributedString._getIterator25069)) as java.text.AttributedCharacterIterator;
		}
		internal static global::MonoJavaBridge.MethodId _getIterator25070;
		public virtual global::java.text.AttributedCharacterIterator getIterator(java.text.AttributedCharacterIterator_Attribute[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.text.AttributedCharacterIterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.AttributedString._getIterator25070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.AttributedCharacterIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.text.AttributedCharacterIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.AttributedString.staticClass, global::java.text.AttributedString._getIterator25070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.AttributedCharacterIterator;
		}
		internal static global::MonoJavaBridge.MethodId _getIterator25071;
		public virtual global::java.text.AttributedCharacterIterator getIterator(java.text.AttributedCharacterIterator_Attribute[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.text.AttributedCharacterIterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.AttributedString._getIterator25071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.text.AttributedCharacterIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.text.AttributedCharacterIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.AttributedString.staticClass, global::java.text.AttributedString._getIterator25071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.text.AttributedCharacterIterator;
		}
		internal static global::MonoJavaBridge.MethodId _addAttribute25072;
		public virtual void addAttribute(java.text.AttributedCharacterIterator_Attribute arg0, java.lang.Object arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.AttributedString._addAttribute25072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.AttributedString.staticClass, global::java.text.AttributedString._addAttribute25072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _addAttribute25073;
		public virtual void addAttribute(java.text.AttributedCharacterIterator_Attribute arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.AttributedString._addAttribute25073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.AttributedString.staticClass, global::java.text.AttributedString._addAttribute25073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addAttributes25074;
		public virtual void addAttributes(java.util.Map arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.AttributedString._addAttributes25074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.AttributedString.staticClass, global::java.text.AttributedString._addAttributes25074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _AttributedString25075;
		public AttributedString(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.AttributedString.staticClass, global::java.text.AttributedString._AttributedString25075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AttributedString25076;
		public AttributedString(java.lang.String arg0, java.util.Map arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.AttributedString.staticClass, global::java.text.AttributedString._AttributedString25076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AttributedString25077;
		public AttributedString(java.text.AttributedCharacterIterator arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.AttributedString.staticClass, global::java.text.AttributedString._AttributedString25077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AttributedString25078;
		public AttributedString(java.text.AttributedCharacterIterator arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.AttributedString.staticClass, global::java.text.AttributedString._AttributedString25078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AttributedString25079;
		public AttributedString(java.text.AttributedCharacterIterator arg0, int arg1, int arg2, java.text.AttributedCharacterIterator_Attribute[] arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.AttributedString.staticClass, global::java.text.AttributedString._AttributedString25079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.AttributedString.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/AttributedString"));
			global::java.text.AttributedString._getIterator25069 = @__env.GetMethodIDNoThrow(global::java.text.AttributedString.staticClass, "getIterator", "()Ljava/text/AttributedCharacterIterator;");
			global::java.text.AttributedString._getIterator25070 = @__env.GetMethodIDNoThrow(global::java.text.AttributedString.staticClass, "getIterator", "([Ljava/text/AttributedCharacterIterator$Attribute;)Ljava/text/AttributedCharacterIterator;");
			global::java.text.AttributedString._getIterator25071 = @__env.GetMethodIDNoThrow(global::java.text.AttributedString.staticClass, "getIterator", "([Ljava/text/AttributedCharacterIterator$Attribute;II)Ljava/text/AttributedCharacterIterator;");
			global::java.text.AttributedString._addAttribute25072 = @__env.GetMethodIDNoThrow(global::java.text.AttributedString.staticClass, "addAttribute", "(Ljava/text/AttributedCharacterIterator$Attribute;Ljava/lang/Object;II)V");
			global::java.text.AttributedString._addAttribute25073 = @__env.GetMethodIDNoThrow(global::java.text.AttributedString.staticClass, "addAttribute", "(Ljava/text/AttributedCharacterIterator$Attribute;Ljava/lang/Object;)V");
			global::java.text.AttributedString._addAttributes25074 = @__env.GetMethodIDNoThrow(global::java.text.AttributedString.staticClass, "addAttributes", "(Ljava/util/Map;II)V");
			global::java.text.AttributedString._AttributedString25075 = @__env.GetMethodIDNoThrow(global::java.text.AttributedString.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.text.AttributedString._AttributedString25076 = @__env.GetMethodIDNoThrow(global::java.text.AttributedString.staticClass, "<init>", "(Ljava/lang/String;Ljava/util/Map;)V");
			global::java.text.AttributedString._AttributedString25077 = @__env.GetMethodIDNoThrow(global::java.text.AttributedString.staticClass, "<init>", "(Ljava/text/AttributedCharacterIterator;)V");
			global::java.text.AttributedString._AttributedString25078 = @__env.GetMethodIDNoThrow(global::java.text.AttributedString.staticClass, "<init>", "(Ljava/text/AttributedCharacterIterator;II)V");
			global::java.text.AttributedString._AttributedString25079 = @__env.GetMethodIDNoThrow(global::java.text.AttributedString.staticClass, "<init>", "(Ljava/text/AttributedCharacterIterator;II[Ljava/text/AttributedCharacterIterator$Attribute;)V");
		}
	}
}
