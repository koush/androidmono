namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RectF : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RectF(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.graphics.RectF.staticClass, "toString", "()Ljava/lang/String;", ref global::android.graphics.RectF._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void offset(float arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.RectF.staticClass, "offset", "(FF)V", ref global::android.graphics.RectF._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual bool isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.RectF.staticClass, "isEmpty", "()Z", ref global::android.graphics.RectF._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual bool contains(float arg0, float arg1, float arg2, float arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.RectF.staticClass, "contains", "(FFFF)Z", ref global::android.graphics.RectF._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual bool contains(float arg0, float arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.RectF.staticClass, "contains", "(FF)Z", ref global::android.graphics.RectF._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual bool contains(android.graphics.RectF arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.RectF.staticClass, "contains", "(Landroid/graphics/RectF;)Z", ref global::android.graphics.RectF._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void set(android.graphics.RectF arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.RectF.staticClass, "set", "(Landroid/graphics/RectF;)V", ref global::android.graphics.RectF._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void set(float arg0, float arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.RectF.staticClass, "set", "(FFFF)V", ref global::android.graphics.RectF._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void set(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.RectF.staticClass, "set", "(Landroid/graphics/Rect;)V", ref global::android.graphics.RectF._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void sort()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.RectF.staticClass, "sort", "()V", ref global::android.graphics.RectF._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void round(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.RectF.staticClass, "round", "(Landroid/graphics/Rect;)V", ref global::android.graphics.RectF._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public static bool intersects(android.graphics.RectF arg0, android.graphics.RectF arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.RectF._m11.native == global::System.IntPtr.Zero)
				global::android.graphics.RectF._m11 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.RectF.staticClass, "intersects", "(Landroid/graphics/RectF;Landroid/graphics/RectF;)Z");
			return @__env.CallStaticBooleanMethod(android.graphics.RectF.staticClass, global::android.graphics.RectF._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual bool intersects(float arg0, float arg1, float arg2, float arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.RectF.staticClass, "intersects", "(FFFF)Z", ref global::android.graphics.RectF._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void union(android.graphics.RectF arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.RectF.staticClass, "union", "(Landroid/graphics/RectF;)V", ref global::android.graphics.RectF._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void union(float arg0, float arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.RectF.staticClass, "union", "(FFFF)V", ref global::android.graphics.RectF._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void union(float arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.RectF.staticClass, "union", "(FF)V", ref global::android.graphics.RectF._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual float centerX()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.graphics.RectF.staticClass, "centerX", "()F", ref global::android.graphics.RectF._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual float centerY()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.graphics.RectF.staticClass, "centerY", "()F", ref global::android.graphics.RectF._m17);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual float height()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.graphics.RectF.staticClass, "height", "()F", ref global::android.graphics.RectF._m18);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual float width()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.graphics.RectF.staticClass, "width", "()F", ref global::android.graphics.RectF._m19);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.RectF.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.graphics.RectF._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.RectF.staticClass, "describeContents", "()I", ref global::android.graphics.RectF._m21);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual void readFromParcel(android.os.Parcel arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.RectF.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V", ref global::android.graphics.RectF._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual void setEmpty()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.RectF.staticClass, "setEmpty", "()V", ref global::android.graphics.RectF._m23);
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual void offsetTo(float arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.RectF.staticClass, "offsetTo", "(FF)V", ref global::android.graphics.RectF._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual void inset(float arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.RectF.staticClass, "inset", "(FF)V", ref global::android.graphics.RectF._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual bool intersect(float arg0, float arg1, float arg2, float arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.RectF.staticClass, "intersect", "(FFFF)Z", ref global::android.graphics.RectF._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual bool intersect(android.graphics.RectF arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.RectF.staticClass, "intersect", "(Landroid/graphics/RectF;)Z", ref global::android.graphics.RectF._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual bool setIntersect(android.graphics.RectF arg0, android.graphics.RectF arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.RectF.staticClass, "setIntersect", "(Landroid/graphics/RectF;Landroid/graphics/RectF;)Z", ref global::android.graphics.RectF._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual void roundOut(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.RectF.staticClass, "roundOut", "(Landroid/graphics/Rect;)V", ref global::android.graphics.RectF._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public RectF() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.RectF._m30.native == global::System.IntPtr.Zero)
				global::android.graphics.RectF._m30 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.RectF.staticClass, global::android.graphics.RectF._m30);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public RectF(float arg0, float arg1, float arg2, float arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.RectF._m31.native == global::System.IntPtr.Zero)
				global::android.graphics.RectF._m31 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "<init>", "(FFFF)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.RectF.staticClass, global::android.graphics.RectF._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public RectF(android.graphics.RectF arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.RectF._m32.native == global::System.IntPtr.Zero)
				global::android.graphics.RectF._m32 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "<init>", "(Landroid/graphics/RectF;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.RectF.staticClass, global::android.graphics.RectF._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public RectF(android.graphics.Rect arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.RectF._m33.native == global::System.IntPtr.Zero)
				global::android.graphics.RectF._m33 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "<init>", "(Landroid/graphics/Rect;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.RectF.staticClass, global::android.graphics.RectF._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _left2396;
		public float left
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _left2396);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _top2397;
		public float top
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _top2397);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _right2398;
		public float right
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _right2398);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _bottom2399;
		public float bottom
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _bottom2399);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR2400;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.graphics.RectF.staticClass, _CREATOR2400)) as android.os.Parcelable_Creator;
			}
		}
		static RectF()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.RectF.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/RectF"));
			global::android.graphics.RectF._left2396 = @__env.GetFieldIDNoThrow(global::android.graphics.RectF.staticClass, "left", "F");
			global::android.graphics.RectF._top2397 = @__env.GetFieldIDNoThrow(global::android.graphics.RectF.staticClass, "top", "F");
			global::android.graphics.RectF._right2398 = @__env.GetFieldIDNoThrow(global::android.graphics.RectF.staticClass, "right", "F");
			global::android.graphics.RectF._bottom2399 = @__env.GetFieldIDNoThrow(global::android.graphics.RectF.staticClass, "bottom", "F");
			global::android.graphics.RectF._CREATOR2400 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.RectF.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
