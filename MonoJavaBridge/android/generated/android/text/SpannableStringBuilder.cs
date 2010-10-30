namespace android.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SpannableStringBuilder : java.lang.Object, java.lang.CharSequence, GetChars, Spannable, Editable, java.lang.Appendable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SpannableStringBuilder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.text.SpannableStringBuilder.staticClass, "toString", "()Ljava/lang/String;", ref global::android.text.SpannableStringBuilder._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		 global::java.lang.Appendable java.lang.Appendable.append(char arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.Appendable>(this, global::android.text.SpannableStringBuilder.staticClass, "append", "(C)Ljava/lang/Appendable;", ref global::android.text.SpannableStringBuilder._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Appendable;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::android.text.Editable append(char arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.text.Editable>(this, global::android.text.SpannableStringBuilder.staticClass, "append", "(C)Landroid/text/Editable;", ref global::android.text.SpannableStringBuilder._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.text.Editable;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::android.text.Editable append(java.lang.CharSequence arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.text.Editable>(this, global::android.text.SpannableStringBuilder.staticClass, "append", "(Ljava/lang/CharSequence;)Landroid/text/Editable;", ref global::android.text.SpannableStringBuilder._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.text.Editable;
		}
		public android.text.Editable append(string arg0)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		 global::java.lang.Appendable java.lang.Appendable.append(java.lang.CharSequence arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.Appendable>(this, global::android.text.SpannableStringBuilder.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;", ref global::android.text.SpannableStringBuilder._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Appendable;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::android.text.Editable append(java.lang.CharSequence arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.text.Editable>(this, global::android.text.SpannableStringBuilder.staticClass, "append", "(Ljava/lang/CharSequence;II)Landroid/text/Editable;", ref global::android.text.SpannableStringBuilder._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.text.Editable;
		}
		public android.text.Editable append(string arg0, int arg1, int arg2)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		 global::java.lang.Appendable java.lang.Appendable.append(java.lang.CharSequence arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.Appendable>(this, global::android.text.SpannableStringBuilder.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;", ref global::android.text.SpannableStringBuilder._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.Appendable;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.SpannableStringBuilder.staticClass, "clear", "()V", ref global::android.text.SpannableStringBuilder._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual int length()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.SpannableStringBuilder.staticClass, "length", "()I", ref global::android.text.SpannableStringBuilder._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual char charAt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::android.text.SpannableStringBuilder.staticClass, "charAt", "(I)C", ref global::android.text.SpannableStringBuilder._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void getChars(int arg0, int arg1, char[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.SpannableStringBuilder.staticClass, "getChars", "(II[CI)V", ref global::android.text.SpannableStringBuilder._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::java.lang.CharSequence subSequence(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.text.SpannableStringBuilder.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;", ref global::android.text.SpannableStringBuilder._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::android.text.Editable replace(int arg0, int arg1, java.lang.CharSequence arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.text.Editable>(this, global::android.text.SpannableStringBuilder.staticClass, "replace", "(IILjava/lang/CharSequence;)Landroid/text/Editable;", ref global::android.text.SpannableStringBuilder._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.text.Editable;
		}
		public android.text.Editable replace(int arg0, int arg1, string arg2)
		{
			return replace(arg0, arg1, (global::java.lang.CharSequence)(global::java.lang.String)arg2);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::android.text.Editable replace(int arg0, int arg1, java.lang.CharSequence arg2, int arg3, int arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.text.Editable>(this, global::android.text.SpannableStringBuilder.staticClass, "replace", "(IILjava/lang/CharSequence;II)Landroid/text/Editable;", ref global::android.text.SpannableStringBuilder._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4)) as android.text.Editable;
		}
		public android.text.Editable replace(int arg0, int arg1, string arg2, int arg3, int arg4)
		{
			return replace(arg0, arg1, (global::java.lang.CharSequence)(global::java.lang.String)arg2, arg3, arg4);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public static global::android.text.SpannableStringBuilder valueOf(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.SpannableStringBuilder._m14.native == global::System.IntPtr.Zero)
				global::android.text.SpannableStringBuilder._m14 = @__env.GetStaticMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "valueOf", "(Ljava/lang/CharSequence;)Landroid/text/SpannableStringBuilder;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.SpannableStringBuilder;
		}
		public static android.text.SpannableStringBuilder valueOf(string arg0)
		{
			return valueOf((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual global::android.text.Editable delete(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.text.Editable>(this, global::android.text.SpannableStringBuilder.staticClass, "delete", "(II)Landroid/text/Editable;", ref global::android.text.SpannableStringBuilder._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.text.Editable;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual global::android.text.Editable insert(int arg0, java.lang.CharSequence arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.text.Editable>(this, global::android.text.SpannableStringBuilder.staticClass, "insert", "(ILjava/lang/CharSequence;II)Landroid/text/Editable;", ref global::android.text.SpannableStringBuilder._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as android.text.Editable;
		}
		public android.text.Editable insert(int arg0, string arg1, int arg2, int arg3)
		{
			return insert(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, arg2, arg3);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual global::android.text.Editable insert(int arg0, java.lang.CharSequence arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.text.Editable>(this, global::android.text.SpannableStringBuilder.staticClass, "insert", "(ILjava/lang/CharSequence;)Landroid/text/Editable;", ref global::android.text.SpannableStringBuilder._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.text.Editable;
		}
		public android.text.Editable insert(int arg0, string arg1)
		{
			return insert(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void setFilters(android.text.InputFilter[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.SpannableStringBuilder.staticClass, "setFilters", "([Landroid/text/InputFilter;)V", ref global::android.text.SpannableStringBuilder._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.text.InputFilter[] Filters
		{
			get
			{
				return getFilters();
			}
			set
			{
				setFilters(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual global::android.text.InputFilter[] getFilters()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<android.text.InputFilter>(this, global::android.text.SpannableStringBuilder.staticClass, "getFilters", "()[Landroid/text/InputFilter;", ref global::android.text.SpannableStringBuilder._m19) as android.text.InputFilter[];
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual void clearSpans()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.SpannableStringBuilder.staticClass, "clearSpans", "()V", ref global::android.text.SpannableStringBuilder._m20);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual void setSpan(java.lang.Object arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.SpannableStringBuilder.staticClass, "setSpan", "(Ljava/lang/Object;III)V", ref global::android.text.SpannableStringBuilder._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual void removeSpan(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.SpannableStringBuilder.staticClass, "removeSpan", "(Ljava/lang/Object;)V", ref global::android.text.SpannableStringBuilder._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual global::java.lang.Object[] getSpans(int arg0, int arg1, java.lang.Class arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::android.text.SpannableStringBuilder.staticClass, "getSpans", "(IILjava/lang/Class;)[Ljava/lang/Object;", ref global::android.text.SpannableStringBuilder._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.Object[];
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual int getSpanStart(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.SpannableStringBuilder.staticClass, "getSpanStart", "(Ljava/lang/Object;)I", ref global::android.text.SpannableStringBuilder._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual int getSpanEnd(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.SpannableStringBuilder.staticClass, "getSpanEnd", "(Ljava/lang/Object;)I", ref global::android.text.SpannableStringBuilder._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual int getSpanFlags(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.SpannableStringBuilder.staticClass, "getSpanFlags", "(Ljava/lang/Object;)I", ref global::android.text.SpannableStringBuilder._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual int nextSpanTransition(int arg0, int arg1, java.lang.Class arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.SpannableStringBuilder.staticClass, "nextSpanTransition", "(IILjava/lang/Class;)I", ref global::android.text.SpannableStringBuilder._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public SpannableStringBuilder(java.lang.CharSequence arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.SpannableStringBuilder._m28.native == global::System.IntPtr.Zero)
				global::android.text.SpannableStringBuilder._m28 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "<init>", "(Ljava/lang/CharSequence;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public SpannableStringBuilder(java.lang.CharSequence arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.SpannableStringBuilder._m29.native == global::System.IntPtr.Zero)
				global::android.text.SpannableStringBuilder._m29 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "<init>", "(Ljava/lang/CharSequence;II)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public SpannableStringBuilder() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.SpannableStringBuilder._m30.native == global::System.IntPtr.Zero)
				global::android.text.SpannableStringBuilder._m30 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._m30);
			Init(@__env, handle);
		}
		static SpannableStringBuilder()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.SpannableStringBuilder.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/SpannableStringBuilder"));
		}
		internal static void InitJNI()
		{
		}
	}
}
