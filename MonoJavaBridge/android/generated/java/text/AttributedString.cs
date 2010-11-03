namespace java.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AttributedString : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.text.AttributedCharacterIterator getIterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.text.AttributedCharacterIterator>(this, global::java.text.AttributedString.staticClass, "getIterator", "()Ljava/text/AttributedCharacterIterator;", ref global::java.text.AttributedString._m0) as java.text.AttributedCharacterIterator;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.text.AttributedCharacterIterator getIterator(java.text.AttributedCharacterIterator_Attribute[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.text.AttributedCharacterIterator>(this, global::java.text.AttributedString.staticClass, "getIterator", "([Ljava/text/AttributedCharacterIterator$Attribute;)Ljava/text/AttributedCharacterIterator;", ref global::java.text.AttributedString._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.text.AttributedCharacterIterator;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.text.AttributedCharacterIterator getIterator(java.text.AttributedCharacterIterator_Attribute[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.text.AttributedCharacterIterator>(this, global::java.text.AttributedString.staticClass, "getIterator", "([Ljava/text/AttributedCharacterIterator$Attribute;II)Ljava/text/AttributedCharacterIterator;", ref global::java.text.AttributedString._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.text.AttributedCharacterIterator;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void addAttribute(java.text.AttributedCharacterIterator_Attribute arg0, java.lang.Object arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.AttributedString.staticClass, "addAttribute", "(Ljava/text/AttributedCharacterIterator$Attribute;Ljava/lang/Object;II)V", ref global::java.text.AttributedString._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void addAttribute(java.text.AttributedCharacterIterator_Attribute arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.AttributedString.staticClass, "addAttribute", "(Ljava/text/AttributedCharacterIterator$Attribute;Ljava/lang/Object;)V", ref global::java.text.AttributedString._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void addAttributes(java.util.Map arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.AttributedString.staticClass, "addAttributes", "(Ljava/util/Map;II)V", ref global::java.text.AttributedString._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public AttributedString(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.AttributedString._m6.native == global::System.IntPtr.Zero)
				global::java.text.AttributedString._m6 = @__env.GetMethodIDNoThrow(global::java.text.AttributedString.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.AttributedString.staticClass, global::java.text.AttributedString._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public AttributedString(java.lang.String arg0, java.util.Map arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.AttributedString._m7.native == global::System.IntPtr.Zero)
				global::java.text.AttributedString._m7 = @__env.GetMethodIDNoThrow(global::java.text.AttributedString.staticClass, "<init>", "(Ljava/lang/String;Ljava/util/Map;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.AttributedString.staticClass, global::java.text.AttributedString._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public AttributedString(java.text.AttributedCharacterIterator arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.AttributedString._m8.native == global::System.IntPtr.Zero)
				global::java.text.AttributedString._m8 = @__env.GetMethodIDNoThrow(global::java.text.AttributedString.staticClass, "<init>", "(Ljava/text/AttributedCharacterIterator;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.AttributedString.staticClass, global::java.text.AttributedString._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public AttributedString(java.text.AttributedCharacterIterator arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.AttributedString._m9.native == global::System.IntPtr.Zero)
				global::java.text.AttributedString._m9 = @__env.GetMethodIDNoThrow(global::java.text.AttributedString.staticClass, "<init>", "(Ljava/text/AttributedCharacterIterator;II)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.AttributedString.staticClass, global::java.text.AttributedString._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public AttributedString(java.text.AttributedCharacterIterator arg0, int arg1, int arg2, java.text.AttributedCharacterIterator_Attribute[] arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.AttributedString._m10.native == global::System.IntPtr.Zero)
				global::java.text.AttributedString._m10 = @__env.GetMethodIDNoThrow(global::java.text.AttributedString.staticClass, "<init>", "(Ljava/text/AttributedCharacterIterator;II[Ljava/text/AttributedCharacterIterator$Attribute;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.AttributedString.staticClass, global::java.text.AttributedString._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		static AttributedString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.AttributedString.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/AttributedString"));
		}
	}
}
