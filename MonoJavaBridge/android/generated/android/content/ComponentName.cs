namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class ComponentName : java.lang.Object, android.os.Parcelable, java.lang.Cloneable, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ComponentName(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.ComponentName.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.content.ComponentName._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.ComponentName.staticClass, "toString", "()Ljava/lang/String;", ref global::android.content.ComponentName._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.ComponentName.staticClass, "hashCode", "()I", ref global::android.content.ComponentName._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public global::android.content.ComponentName clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.content.ComponentName>(this, global::android.content.ComponentName.staticClass, "clone", "()Landroid/content/ComponentName;", ref global::android.content.ComponentName._m3) as android.content.ComponentName;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public int compareTo(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.ComponentName.staticClass, "compareTo", "(Ljava/lang/Object;)I", ref global::android.content.ComponentName._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public int compareTo(android.content.ComponentName arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.ComponentName.staticClass, "compareTo", "(Landroid/content/ComponentName;)I", ref global::android.content.ComponentName._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String ClassName
		{
			get
			{
				return getClassName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public global::java.lang.String getClassName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.ComponentName.staticClass, "getClassName", "()Ljava/lang/String;", ref global::android.content.ComponentName._m6) as java.lang.String;
		}
		public new global::java.lang.String PackageName
		{
			get
			{
				return getPackageName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public global::java.lang.String getPackageName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.ComponentName.staticClass, "getPackageName", "()Ljava/lang/String;", ref global::android.content.ComponentName._m7) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ComponentName.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.content.ComponentName._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static void writeToParcel(android.content.ComponentName arg0, android.os.Parcel arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ComponentName._m9.native == global::System.IntPtr.Zero)
				global::android.content.ComponentName._m9 = @__env.GetStaticMethodIDNoThrow(global::android.content.ComponentName.staticClass, "writeToParcel", "(Landroid/content/ComponentName;Landroid/os/Parcel;)V");
			@__env.CallStaticVoidMethod(android.content.ComponentName.staticClass, global::android.content.ComponentName._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.ComponentName.staticClass, "describeContents", "()I", ref global::android.content.ComponentName._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public static global::android.content.ComponentName readFromParcel(android.os.Parcel arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ComponentName._m11.native == global::System.IntPtr.Zero)
				global::android.content.ComponentName._m11 = @__env.GetStaticMethodIDNoThrow(global::android.content.ComponentName.staticClass, "readFromParcel", "(Landroid/os/Parcel;)Landroid/content/ComponentName;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.ComponentName>(@__env.CallStaticObjectMethod(android.content.ComponentName.staticClass, global::android.content.ComponentName._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ComponentName;
		}
		public new global::java.lang.String ShortClassName
		{
			get
			{
				return getShortClassName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public global::java.lang.String getShortClassName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.ComponentName.staticClass, "getShortClassName", "()Ljava/lang/String;", ref global::android.content.ComponentName._m12) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public global::java.lang.String flattenToString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.ComponentName.staticClass, "flattenToString", "()Ljava/lang/String;", ref global::android.content.ComponentName._m13) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public global::java.lang.String flattenToShortString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.ComponentName.staticClass, "flattenToShortString", "()Ljava/lang/String;", ref global::android.content.ComponentName._m14) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public static global::android.content.ComponentName unflattenFromString(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ComponentName._m15.native == global::System.IntPtr.Zero)
				global::android.content.ComponentName._m15 = @__env.GetStaticMethodIDNoThrow(global::android.content.ComponentName.staticClass, "unflattenFromString", "(Ljava/lang/String;)Landroid/content/ComponentName;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.ComponentName>(@__env.CallStaticObjectMethod(android.content.ComponentName.staticClass, global::android.content.ComponentName._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ComponentName;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public global::java.lang.String toShortString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.ComponentName.staticClass, "toShortString", "()Ljava/lang/String;", ref global::android.content.ComponentName._m16) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public ComponentName(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ComponentName._m17.native == global::System.IntPtr.Zero)
				global::android.content.ComponentName._m17 = @__env.GetMethodIDNoThrow(global::android.content.ComponentName.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ComponentName.staticClass, global::android.content.ComponentName._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public ComponentName(android.content.Context arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ComponentName._m18.native == global::System.IntPtr.Zero)
				global::android.content.ComponentName._m18 = @__env.GetMethodIDNoThrow(global::android.content.ComponentName.staticClass, "<init>", "(Landroid/content/Context;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ComponentName.staticClass, global::android.content.ComponentName._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public ComponentName(android.content.Context arg0, java.lang.Class arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ComponentName._m19.native == global::System.IntPtr.Zero)
				global::android.content.ComponentName._m19 = @__env.GetMethodIDNoThrow(global::android.content.ComponentName.staticClass, "<init>", "(Landroid/content/Context;Ljava/lang/Class;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ComponentName.staticClass, global::android.content.ComponentName._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public ComponentName(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ComponentName._m20.native == global::System.IntPtr.Zero)
				global::android.content.ComponentName._m20 = @__env.GetMethodIDNoThrow(global::android.content.ComponentName.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ComponentName.staticClass, global::android.content.ComponentName._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR1616;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.ComponentName.staticClass, _CREATOR1616)) as android.os.Parcelable_Creator;
			}
		}
		static ComponentName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.ComponentName.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/ComponentName"));
			global::android.content.ComponentName._CREATOR1616 = @__env.GetStaticFieldIDNoThrow(global::android.content.ComponentName.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
