namespace java.lang
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.lang.AbstractStringBuilder_))]
	public abstract partial class AbstractStringBuilder : java.lang.Object, Appendable, CharSequence
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractStringBuilder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract global::java.lang.String toString();
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.AbstractStringBuilder append(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "append", "(J)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.AbstractStringBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.lang.Appendable append(java.lang.CharSequence arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.Appendable>(this, global::java.lang.AbstractStringBuilder.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;", ref global::java.lang.AbstractStringBuilder._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.Appendable;
		}
		public java.lang.Appendable append(string arg0, int arg1, int arg2)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.AbstractStringBuilder append(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "append", "(I)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.AbstractStringBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.lang.Appendable append(char arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.Appendable>(this, global::java.lang.AbstractStringBuilder.staticClass, "append", "(C)Ljava/lang/Appendable;", ref global::java.lang.AbstractStringBuilder._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Appendable;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.lang.AbstractStringBuilder append(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "append", "(Z)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.AbstractStringBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.lang.AbstractStringBuilder append(char[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "append", "([CII)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.AbstractStringBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.lang.Appendable append(java.lang.CharSequence arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.Appendable>(this, global::java.lang.AbstractStringBuilder.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;", ref global::java.lang.AbstractStringBuilder._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Appendable;
		}
		public java.lang.Appendable append(string arg0)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.lang.AbstractStringBuilder append(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "append", "(Ljava/lang/Object;)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.AbstractStringBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::java.lang.AbstractStringBuilder append(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "append", "(Ljava/lang/String;)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.AbstractStringBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::java.lang.AbstractStringBuilder append(java.lang.StringBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "append", "(Ljava/lang/StringBuffer;)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.AbstractStringBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::java.lang.AbstractStringBuilder append(char[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "append", "([C)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.AbstractStringBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::java.lang.AbstractStringBuilder append(double arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "append", "(D)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.AbstractStringBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::java.lang.AbstractStringBuilder append(float arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "append", "(F)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.AbstractStringBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual int indexOf(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "indexOf", "(Ljava/lang/String;I)I", ref global::java.lang.AbstractStringBuilder._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual int indexOf(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "indexOf", "(Ljava/lang/String;)I", ref global::java.lang.AbstractStringBuilder._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual int length()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "length", "()I", ref global::java.lang.AbstractStringBuilder._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual char charAt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "charAt", "(I)C", ref global::java.lang.AbstractStringBuilder._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual int codePointAt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "codePointAt", "(I)I", ref global::java.lang.AbstractStringBuilder._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual int codePointBefore(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "codePointBefore", "(I)I", ref global::java.lang.AbstractStringBuilder._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual int codePointCount(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "codePointCount", "(II)I", ref global::java.lang.AbstractStringBuilder._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual int offsetByCodePoints(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "offsetByCodePoints", "(II)I", ref global::java.lang.AbstractStringBuilder._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual void getChars(int arg0, int arg1, char[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "getChars", "(II[CI)V", ref global::java.lang.AbstractStringBuilder._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual int lastIndexOf(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "lastIndexOf", "(Ljava/lang/String;I)I", ref global::java.lang.AbstractStringBuilder._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual int lastIndexOf(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "lastIndexOf", "(Ljava/lang/String;)I", ref global::java.lang.AbstractStringBuilder._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual global::java.lang.String substring(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.AbstractStringBuilder.staticClass, "substring", "(II)Ljava/lang/String;", ref global::java.lang.AbstractStringBuilder._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual global::java.lang.String substring(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.AbstractStringBuilder.staticClass, "substring", "(I)Ljava/lang/String;", ref global::java.lang.AbstractStringBuilder._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual global::java.lang.CharSequence subSequence(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::java.lang.AbstractStringBuilder.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;", ref global::java.lang.AbstractStringBuilder._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual global::java.lang.AbstractStringBuilder replace(int arg0, int arg1, java.lang.String arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "replace", "(IILjava/lang/String;)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.AbstractStringBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual void trimToSize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "trimToSize", "()V", ref global::java.lang.AbstractStringBuilder._m29);
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual void ensureCapacity(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "ensureCapacity", "(I)V", ref global::java.lang.AbstractStringBuilder._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual int capacity()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "capacity", "()I", ref global::java.lang.AbstractStringBuilder._m31);
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public virtual void setLength(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "setLength", "(I)V", ref global::java.lang.AbstractStringBuilder._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual void setCharAt(int arg0, char arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "setCharAt", "(IC)V", ref global::java.lang.AbstractStringBuilder._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual global::java.lang.AbstractStringBuilder appendCodePoint(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "appendCodePoint", "(I)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.AbstractStringBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public virtual global::java.lang.AbstractStringBuilder delete(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "delete", "(II)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.AbstractStringBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public virtual global::java.lang.AbstractStringBuilder deleteCharAt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "deleteCharAt", "(I)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.AbstractStringBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, char arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "insert", "(IC)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.AbstractStringBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "insert", "(II)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.AbstractStringBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "insert", "(IJ)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.AbstractStringBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, float arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "insert", "(IF)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.AbstractStringBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, double arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "insert", "(ID)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.AbstractStringBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "insert", "(ILjava/lang/String;)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.AbstractStringBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "insert", "(ILjava/lang/Object;)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.AbstractStringBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, char[] arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "insert", "(I[CII)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as java.lang.AbstractStringBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, char[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "insert", "(I[C)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.AbstractStringBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m46;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, java.lang.CharSequence arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "insert", "(ILjava/lang/CharSequence;)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._m46, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.AbstractStringBuilder;
		}
		public java.lang.AbstractStringBuilder insert(int arg0, string arg1)
		{
			return insert(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		private static global::MonoJavaBridge.MethodId _m47;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, java.lang.CharSequence arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "insert", "(ILjava/lang/CharSequence;II)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._m47, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as java.lang.AbstractStringBuilder;
		}
		public java.lang.AbstractStringBuilder insert(int arg0, string arg1, int arg2, int arg3)
		{
			return insert(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, arg2, arg3);
		}
		private static global::MonoJavaBridge.MethodId _m48;
		public virtual global::java.lang.AbstractStringBuilder insert(int arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "insert", "(IZ)Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._m48, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.AbstractStringBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m49;
		public virtual global::java.lang.AbstractStringBuilder reverse()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.AbstractStringBuilder.staticClass, "reverse", "()Ljava/lang/AbstractStringBuilder;", ref global::java.lang.AbstractStringBuilder._m49) as java.lang.AbstractStringBuilder;
		}
		static AbstractStringBuilder()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.AbstractStringBuilder.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/AbstractStringBuilder"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.AbstractStringBuilder))]
	internal sealed partial class AbstractStringBuilder_ : java.lang.AbstractStringBuilder
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractStringBuilder_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.AbstractStringBuilder_.staticClass, "toString", "()Ljava/lang/String;", ref global::java.lang.AbstractStringBuilder_._m0) as java.lang.String;
		}
		static AbstractStringBuilder_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.AbstractStringBuilder_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/AbstractStringBuilder"));
		}
	}
}
