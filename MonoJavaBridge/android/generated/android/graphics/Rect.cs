namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Rect : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Rect(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Rect.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.graphics.Rect._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.graphics.Rect.staticClass, "toString", "()Ljava/lang/String;", ref global::android.graphics.Rect._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public void offset(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Rect.staticClass, "offset", "(II)V", ref global::android.graphics.Rect._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public bool isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Rect.staticClass, "isEmpty", "()Z", ref global::android.graphics.Rect._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public bool contains(android.graphics.Rect arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Rect.staticClass, "contains", "(Landroid/graphics/Rect;)Z", ref global::android.graphics.Rect._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public bool contains(int arg0, int arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Rect.staticClass, "contains", "(IIII)Z", ref global::android.graphics.Rect._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public bool contains(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Rect.staticClass, "contains", "(II)Z", ref global::android.graphics.Rect._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public void set(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Rect.staticClass, "set", "(IIII)V", ref global::android.graphics.Rect._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public void set(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Rect.staticClass, "set", "(Landroid/graphics/Rect;)V", ref global::android.graphics.Rect._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public void sort()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Rect.staticClass, "sort", "()V", ref global::android.graphics.Rect._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static bool intersects(android.graphics.Rect arg0, android.graphics.Rect arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Rect._m10.native == global::System.IntPtr.Zero)
				global::android.graphics.Rect._m10 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Rect.staticClass, "intersects", "(Landroid/graphics/Rect;Landroid/graphics/Rect;)Z");
			return @__env.CallStaticBooleanMethod(android.graphics.Rect.staticClass, global::android.graphics.Rect._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public bool intersects(int arg0, int arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Rect.staticClass, "intersects", "(IIII)Z", ref global::android.graphics.Rect._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public void union(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Rect.staticClass, "union", "(II)V", ref global::android.graphics.Rect._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public void union(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Rect.staticClass, "union", "(IIII)V", ref global::android.graphics.Rect._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public void union(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Rect.staticClass, "union", "(Landroid/graphics/Rect;)V", ref global::android.graphics.Rect._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public int centerX()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Rect.staticClass, "centerX", "()I", ref global::android.graphics.Rect._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public int centerY()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Rect.staticClass, "centerY", "()I", ref global::android.graphics.Rect._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public int height()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Rect.staticClass, "height", "()I", ref global::android.graphics.Rect._m17);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public int width()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Rect.staticClass, "width", "()I", ref global::android.graphics.Rect._m18);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Rect.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.graphics.Rect._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Rect.staticClass, "describeContents", "()I", ref global::android.graphics.Rect._m20);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public void readFromParcel(android.os.Parcel arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Rect.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V", ref global::android.graphics.Rect._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public global::java.lang.String flattenToString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.graphics.Rect.staticClass, "flattenToString", "()Ljava/lang/String;", ref global::android.graphics.Rect._m22) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public static global::android.graphics.Rect unflattenFromString(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Rect._m23.native == global::System.IntPtr.Zero)
				global::android.graphics.Rect._m23 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Rect.staticClass, "unflattenFromString", "(Ljava/lang/String;)Landroid/graphics/Rect;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Rect>(@__env.CallStaticObjectMethod(android.graphics.Rect.staticClass, global::android.graphics.Rect._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Rect;
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public global::java.lang.String toShortString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.graphics.Rect.staticClass, "toShortString", "()Ljava/lang/String;", ref global::android.graphics.Rect._m24) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public void setEmpty()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Rect.staticClass, "setEmpty", "()V", ref global::android.graphics.Rect._m25);
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public float exactCenterX()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.graphics.Rect.staticClass, "exactCenterX", "()F", ref global::android.graphics.Rect._m26);
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public float exactCenterY()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.graphics.Rect.staticClass, "exactCenterY", "()F", ref global::android.graphics.Rect._m27);
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public void offsetTo(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Rect.staticClass, "offsetTo", "(II)V", ref global::android.graphics.Rect._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public void inset(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Rect.staticClass, "inset", "(II)V", ref global::android.graphics.Rect._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public bool intersect(int arg0, int arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Rect.staticClass, "intersect", "(IIII)Z", ref global::android.graphics.Rect._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public bool intersect(android.graphics.Rect arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Rect.staticClass, "intersect", "(Landroid/graphics/Rect;)Z", ref global::android.graphics.Rect._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public bool setIntersect(android.graphics.Rect arg0, android.graphics.Rect arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Rect.staticClass, "setIntersect", "(Landroid/graphics/Rect;Landroid/graphics/Rect;)Z", ref global::android.graphics.Rect._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public Rect() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Rect._m33.native == global::System.IntPtr.Zero)
				global::android.graphics.Rect._m33 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Rect.staticClass, global::android.graphics.Rect._m33);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public Rect(int arg0, int arg1, int arg2, int arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Rect._m34.native == global::System.IntPtr.Zero)
				global::android.graphics.Rect._m34 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "<init>", "(IIII)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Rect.staticClass, global::android.graphics.Rect._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public Rect(android.graphics.Rect arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Rect._m35.native == global::System.IntPtr.Zero)
				global::android.graphics.Rect._m35 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "<init>", "(Landroid/graphics/Rect;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Rect.staticClass, global::android.graphics.Rect._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _left2391;
		public int left
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _left2391);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _top2392;
		public int top
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _top2392);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _right2393;
		public int right
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _right2393);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _bottom2394;
		public int bottom
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _bottom2394);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR2395;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.graphics.Rect.staticClass, _CREATOR2395)) as android.os.Parcelable_Creator;
			}
		}
		static Rect()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Rect.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Rect"));
			global::android.graphics.Rect._left2391 = @__env.GetFieldIDNoThrow(global::android.graphics.Rect.staticClass, "left", "I");
			global::android.graphics.Rect._top2392 = @__env.GetFieldIDNoThrow(global::android.graphics.Rect.staticClass, "top", "I");
			global::android.graphics.Rect._right2393 = @__env.GetFieldIDNoThrow(global::android.graphics.Rect.staticClass, "right", "I");
			global::android.graphics.Rect._bottom2394 = @__env.GetFieldIDNoThrow(global::android.graphics.Rect.staticClass, "bottom", "I");
			global::android.graphics.Rect._CREATOR2395 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Rect.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
