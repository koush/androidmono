namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Rect : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Rect(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals5668;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Rect.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.graphics.Rect._equals5668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString5669;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.graphics.Rect.staticClass, "toString", "()Ljava/lang/String;", ref global::android.graphics.Rect._toString5669) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _offset5670;
		public void offset(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Rect.staticClass, "offset", "(II)V", ref global::android.graphics.Rect._offset5670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty5671;
		public bool isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Rect.staticClass, "isEmpty", "()Z", ref global::android.graphics.Rect._isEmpty5671);
		}
		internal static global::MonoJavaBridge.MethodId _contains5672;
		public bool contains(android.graphics.Rect arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Rect.staticClass, "contains", "(Landroid/graphics/Rect;)Z", ref global::android.graphics.Rect._contains5672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _contains5673;
		public bool contains(int arg0, int arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Rect.staticClass, "contains", "(IIII)Z", ref global::android.graphics.Rect._contains5673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _contains5674;
		public bool contains(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Rect.staticClass, "contains", "(II)Z", ref global::android.graphics.Rect._contains5674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _set5675;
		public void set(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Rect.staticClass, "set", "(IIII)V", ref global::android.graphics.Rect._set5675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _set5676;
		public void set(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Rect.staticClass, "set", "(Landroid/graphics/Rect;)V", ref global::android.graphics.Rect._set5676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sort5677;
		public void sort()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Rect.staticClass, "sort", "()V", ref global::android.graphics.Rect._sort5677);
		}
		internal static global::MonoJavaBridge.MethodId _intersects5678;
		public static bool intersects(android.graphics.Rect arg0, android.graphics.Rect arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Rect._intersects5678.native == global::System.IntPtr.Zero)
				global::android.graphics.Rect._intersects5678 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Rect.staticClass, "intersects", "(Landroid/graphics/Rect;Landroid/graphics/Rect;)Z");
			return @__env.CallStaticBooleanMethod(android.graphics.Rect.staticClass, global::android.graphics.Rect._intersects5678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _intersects5679;
		public bool intersects(int arg0, int arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Rect.staticClass, "intersects", "(IIII)Z", ref global::android.graphics.Rect._intersects5679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _union5680;
		public void union(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Rect.staticClass, "union", "(II)V", ref global::android.graphics.Rect._union5680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _union5681;
		public void union(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Rect.staticClass, "union", "(IIII)V", ref global::android.graphics.Rect._union5681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _union5682;
		public void union(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Rect.staticClass, "union", "(Landroid/graphics/Rect;)V", ref global::android.graphics.Rect._union5682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _centerX5683;
		public int centerX()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Rect.staticClass, "centerX", "()I", ref global::android.graphics.Rect._centerX5683);
		}
		internal static global::MonoJavaBridge.MethodId _centerY5684;
		public int centerY()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Rect.staticClass, "centerY", "()I", ref global::android.graphics.Rect._centerY5684);
		}
		internal static global::MonoJavaBridge.MethodId _height5685;
		public int height()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Rect.staticClass, "height", "()I", ref global::android.graphics.Rect._height5685);
		}
		internal static global::MonoJavaBridge.MethodId _width5686;
		public int width()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Rect.staticClass, "width", "()I", ref global::android.graphics.Rect._width5686);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel5687;
		public void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Rect.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.graphics.Rect._writeToParcel5687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents5688;
		public int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Rect.staticClass, "describeContents", "()I", ref global::android.graphics.Rect._describeContents5688);
		}
		internal static global::MonoJavaBridge.MethodId _readFromParcel5689;
		public void readFromParcel(android.os.Parcel arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Rect.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V", ref global::android.graphics.Rect._readFromParcel5689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _flattenToString5690;
		public global::java.lang.String flattenToString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.graphics.Rect.staticClass, "flattenToString", "()Ljava/lang/String;", ref global::android.graphics.Rect._flattenToString5690) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _unflattenFromString5691;
		public static global::android.graphics.Rect unflattenFromString(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Rect._unflattenFromString5691.native == global::System.IntPtr.Zero)
				global::android.graphics.Rect._unflattenFromString5691 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Rect.staticClass, "unflattenFromString", "(Ljava/lang/String;)Landroid/graphics/Rect;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Rect>(@__env.CallStaticObjectMethod(android.graphics.Rect.staticClass, global::android.graphics.Rect._unflattenFromString5691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Rect;
		}
		internal static global::MonoJavaBridge.MethodId _toShortString5692;
		public global::java.lang.String toShortString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.graphics.Rect.staticClass, "toShortString", "()Ljava/lang/String;", ref global::android.graphics.Rect._toShortString5692) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setEmpty5693;
		public void setEmpty()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Rect.staticClass, "setEmpty", "()V", ref global::android.graphics.Rect._setEmpty5693);
		}
		internal static global::MonoJavaBridge.MethodId _exactCenterX5694;
		public float exactCenterX()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.graphics.Rect.staticClass, "exactCenterX", "()F", ref global::android.graphics.Rect._exactCenterX5694);
		}
		internal static global::MonoJavaBridge.MethodId _exactCenterY5695;
		public float exactCenterY()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.graphics.Rect.staticClass, "exactCenterY", "()F", ref global::android.graphics.Rect._exactCenterY5695);
		}
		internal static global::MonoJavaBridge.MethodId _offsetTo5696;
		public void offsetTo(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Rect.staticClass, "offsetTo", "(II)V", ref global::android.graphics.Rect._offsetTo5696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _inset5697;
		public void inset(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Rect.staticClass, "inset", "(II)V", ref global::android.graphics.Rect._inset5697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _intersect5698;
		public bool intersect(int arg0, int arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Rect.staticClass, "intersect", "(IIII)Z", ref global::android.graphics.Rect._intersect5698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _intersect5699;
		public bool intersect(android.graphics.Rect arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Rect.staticClass, "intersect", "(Landroid/graphics/Rect;)Z", ref global::android.graphics.Rect._intersect5699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIntersect5700;
		public bool setIntersect(android.graphics.Rect arg0, android.graphics.Rect arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Rect.staticClass, "setIntersect", "(Landroid/graphics/Rect;Landroid/graphics/Rect;)Z", ref global::android.graphics.Rect._setIntersect5700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _Rect5701;
		public Rect() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Rect._Rect5701.native == global::System.IntPtr.Zero)
				global::android.graphics.Rect._Rect5701 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Rect.staticClass, global::android.graphics.Rect._Rect5701);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Rect5702;
		public Rect(int arg0, int arg1, int arg2, int arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Rect._Rect5702.native == global::System.IntPtr.Zero)
				global::android.graphics.Rect._Rect5702 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "<init>", "(IIII)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Rect.staticClass, global::android.graphics.Rect._Rect5702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Rect5703;
		public Rect(android.graphics.Rect arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Rect._Rect5703.native == global::System.IntPtr.Zero)
				global::android.graphics.Rect._Rect5703 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "<init>", "(Landroid/graphics/Rect;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Rect.staticClass, global::android.graphics.Rect._Rect5703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _left5704;
		public int left
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _left5704);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _top5705;
		public int top
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _top5705);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _right5706;
		public int right
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _right5706);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _bottom5707;
		public int bottom
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _bottom5707);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR5708;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.graphics.Rect.staticClass, _CREATOR5708)) as android.os.Parcelable_Creator;
			}
		}
		static Rect()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Rect.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Rect"));
			global::android.graphics.Rect._left5704 = @__env.GetFieldIDNoThrow(global::android.graphics.Rect.staticClass, "left", "I");
			global::android.graphics.Rect._top5705 = @__env.GetFieldIDNoThrow(global::android.graphics.Rect.staticClass, "top", "I");
			global::android.graphics.Rect._right5706 = @__env.GetFieldIDNoThrow(global::android.graphics.Rect.staticClass, "right", "I");
			global::android.graphics.Rect._bottom5707 = @__env.GetFieldIDNoThrow(global::android.graphics.Rect.staticClass, "bottom", "I");
			global::android.graphics.Rect._CREATOR5708 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Rect.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
