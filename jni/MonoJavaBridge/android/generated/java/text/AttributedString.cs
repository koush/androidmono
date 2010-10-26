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
		internal static global::MonoJavaBridge.MethodId _getIterator25187;
		public virtual global::java.text.AttributedCharacterIterator getIterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.text.AttributedCharacterIterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.AttributedString._getIterator25187)) as java.text.AttributedCharacterIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.text.AttributedCharacterIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.AttributedString.staticClass, global::java.text.AttributedString._getIterator25187)) as java.text.AttributedCharacterIterator;
		}
		internal static global::MonoJavaBridge.MethodId _getIterator25188;
		public virtual global::java.text.AttributedCharacterIterator getIterator(java.text.AttributedCharacterIterator_Attribute[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.text.AttributedCharacterIterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.AttributedString._getIterator25188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.AttributedCharacterIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.text.AttributedCharacterIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.AttributedString.staticClass, global::java.text.AttributedString._getIterator25188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.AttributedCharacterIterator;
		}
		internal static global::MonoJavaBridge.MethodId _getIterator25189;
		public virtual global::java.text.AttributedCharacterIterator getIterator(java.text.AttributedCharacterIterator_Attribute[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.text.AttributedCharacterIterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.AttributedString._getIterator25189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.text.AttributedCharacterIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.text.AttributedCharacterIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.AttributedString.staticClass, global::java.text.AttributedString._getIterator25189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.text.AttributedCharacterIterator;
		}
		internal static global::MonoJavaBridge.MethodId _addAttribute25190;
		public virtual void addAttribute(java.text.AttributedCharacterIterator_Attribute arg0, java.lang.Object arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.AttributedString._addAttribute25190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.AttributedString.staticClass, global::java.text.AttributedString._addAttribute25190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _addAttribute25191;
		public virtual void addAttribute(java.text.AttributedCharacterIterator_Attribute arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.AttributedString._addAttribute25191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.AttributedString.staticClass, global::java.text.AttributedString._addAttribute25191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addAttributes25192;
		public virtual void addAttributes(java.util.Map arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.AttributedString._addAttributes25192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.AttributedString.staticClass, global::java.text.AttributedString._addAttributes25192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _AttributedString25193;
		public AttributedString(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.AttributedString.staticClass, global::java.text.AttributedString._AttributedString25193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AttributedString25194;
		public AttributedString(java.lang.String arg0, java.util.Map arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.AttributedString.staticClass, global::java.text.AttributedString._AttributedString25194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AttributedString25195;
		public AttributedString(java.text.AttributedCharacterIterator arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.AttributedString.staticClass, global::java.text.AttributedString._AttributedString25195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AttributedString25196;
		public AttributedString(java.text.AttributedCharacterIterator arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.AttributedString.staticClass, global::java.text.AttributedString._AttributedString25196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AttributedString25197;
		public AttributedString(java.text.AttributedCharacterIterator arg0, int arg1, int arg2, java.text.AttributedCharacterIterator_Attribute[] arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.AttributedString.staticClass, global::java.text.AttributedString._AttributedString25197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.AttributedString.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/AttributedString"));
			global::java.text.AttributedString._getIterator25187 = @__env.GetMethodIDNoThrow(global::java.text.AttributedString.staticClass, "getIterator", "()Ljava/text/AttributedCharacterIterator;");
			global::java.text.AttributedString._getIterator25188 = @__env.GetMethodIDNoThrow(global::java.text.AttributedString.staticClass, "getIterator", "([Ljava/text/AttributedCharacterIterator$Attribute;)Ljava/text/AttributedCharacterIterator;");
			global::java.text.AttributedString._getIterator25189 = @__env.GetMethodIDNoThrow(global::java.text.AttributedString.staticClass, "getIterator", "([Ljava/text/AttributedCharacterIterator$Attribute;II)Ljava/text/AttributedCharacterIterator;");
			global::java.text.AttributedString._addAttribute25190 = @__env.GetMethodIDNoThrow(global::java.text.AttributedString.staticClass, "addAttribute", "(Ljava/text/AttributedCharacterIterator$Attribute;Ljava/lang/Object;II)V");
			global::java.text.AttributedString._addAttribute25191 = @__env.GetMethodIDNoThrow(global::java.text.AttributedString.staticClass, "addAttribute", "(Ljava/text/AttributedCharacterIterator$Attribute;Ljava/lang/Object;)V");
			global::java.text.AttributedString._addAttributes25192 = @__env.GetMethodIDNoThrow(global::java.text.AttributedString.staticClass, "addAttributes", "(Ljava/util/Map;II)V");
			global::java.text.AttributedString._AttributedString25193 = @__env.GetMethodIDNoThrow(global::java.text.AttributedString.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.text.AttributedString._AttributedString25194 = @__env.GetMethodIDNoThrow(global::java.text.AttributedString.staticClass, "<init>", "(Ljava/lang/String;Ljava/util/Map;)V");
			global::java.text.AttributedString._AttributedString25195 = @__env.GetMethodIDNoThrow(global::java.text.AttributedString.staticClass, "<init>", "(Ljava/text/AttributedCharacterIterator;)V");
			global::java.text.AttributedString._AttributedString25196 = @__env.GetMethodIDNoThrow(global::java.text.AttributedString.staticClass, "<init>", "(Ljava/text/AttributedCharacterIterator;II)V");
			global::java.text.AttributedString._AttributedString25197 = @__env.GetMethodIDNoThrow(global::java.text.AttributedString.staticClass, "<init>", "(Ljava/text/AttributedCharacterIterator;II[Ljava/text/AttributedCharacterIterator$Attribute;)V");
		}
	}
}
