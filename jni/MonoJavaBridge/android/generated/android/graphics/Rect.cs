namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Rect : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Rect()
		{
			InitJNI();
		}
		internal Rect(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals3668;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Rect._equals3668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._equals3668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString3669;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Rect._toString3669)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._toString3669)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _offset3670;
		public void offset(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Rect._offset3670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._offset3670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty3671;
		public bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Rect._isEmpty3671);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._isEmpty3671);
		}
		internal static global::MonoJavaBridge.MethodId _contains3672;
		public bool contains(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Rect._contains3672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._contains3672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _contains3673;
		public bool contains(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Rect._contains3673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._contains3673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _contains3674;
		public bool contains(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Rect._contains3674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._contains3674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _set3675;
		public void set(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Rect._set3675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._set3675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _set3676;
		public void set(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Rect._set3676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._set3676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sort3677;
		public void sort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Rect._sort3677);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._sort3677);
		}
		internal static global::MonoJavaBridge.MethodId _intersects3678;
		public static bool intersects(android.graphics.Rect arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.graphics.Rect.staticClass, global::android.graphics.Rect._intersects3678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _intersects3679;
		public bool intersects(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Rect._intersects3679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._intersects3679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _union3680;
		public void union(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Rect._union3680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._union3680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _union3681;
		public void union(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Rect._union3681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._union3681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _union3682;
		public void union(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Rect._union3682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._union3682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _centerX3683;
		public int centerX() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Rect._centerX3683);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._centerX3683);
		}
		internal static global::MonoJavaBridge.MethodId _centerY3684;
		public int centerY() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Rect._centerY3684);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._centerY3684);
		}
		internal static global::MonoJavaBridge.MethodId _height3685;
		public int height() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Rect._height3685);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._height3685);
		}
		internal static global::MonoJavaBridge.MethodId _width3686;
		public int width() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Rect._width3686);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._width3686);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel3687;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Rect._writeToParcel3687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._writeToParcel3687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents3688;
		public int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Rect._describeContents3688);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._describeContents3688);
		}
		internal static global::MonoJavaBridge.MethodId _readFromParcel3689;
		public void readFromParcel(android.os.Parcel arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Rect._readFromParcel3689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._readFromParcel3689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _flattenToString3690;
		public global::java.lang.String flattenToString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Rect._flattenToString3690)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._flattenToString3690)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _unflattenFromString3691;
		public static global::android.graphics.Rect unflattenFromString(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Rect.staticClass, global::android.graphics.Rect._unflattenFromString3691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Rect;
		}
		internal static global::MonoJavaBridge.MethodId _toShortString3692;
		public global::java.lang.String toShortString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Rect._toShortString3692)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._toShortString3692)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setEmpty3693;
		public void setEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Rect._setEmpty3693);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._setEmpty3693);
		}
		internal static global::MonoJavaBridge.MethodId _exactCenterX3694;
		public float exactCenterX() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.Rect._exactCenterX3694);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._exactCenterX3694);
		}
		internal static global::MonoJavaBridge.MethodId _exactCenterY3695;
		public float exactCenterY() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.Rect._exactCenterY3695);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._exactCenterY3695);
		}
		internal static global::MonoJavaBridge.MethodId _offsetTo3696;
		public void offsetTo(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Rect._offsetTo3696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._offsetTo3696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _inset3697;
		public void inset(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Rect._inset3697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._inset3697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _intersect3698;
		public bool intersect(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Rect._intersect3698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._intersect3698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _intersect3699;
		public bool intersect(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Rect._intersect3699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._intersect3699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIntersect3700;
		public bool setIntersect(android.graphics.Rect arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Rect._setIntersect3700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._setIntersect3700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _Rect3701;
		public Rect()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Rect.staticClass, global::android.graphics.Rect._Rect3701);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Rect3702;
		public Rect(int arg0, int arg1, int arg2, int arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Rect.staticClass, global::android.graphics.Rect._Rect3702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Rect3703;
		public Rect(android.graphics.Rect arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Rect.staticClass, global::android.graphics.Rect._Rect3703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _left3704;
		public int left
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _top3705;
		public int top
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _right3706;
		public int right
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _bottom3707;
		public int bottom
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR3708;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Rect.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Rect"));
			global::android.graphics.Rect._equals3668 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.graphics.Rect._toString3669 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "toString", "()Ljava/lang/String;");
			global::android.graphics.Rect._offset3670 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "offset", "(II)V");
			global::android.graphics.Rect._isEmpty3671 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "isEmpty", "()Z");
			global::android.graphics.Rect._contains3672 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "contains", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.Rect._contains3673 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "contains", "(IIII)Z");
			global::android.graphics.Rect._contains3674 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "contains", "(II)Z");
			global::android.graphics.Rect._set3675 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "set", "(IIII)V");
			global::android.graphics.Rect._set3676 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "set", "(Landroid/graphics/Rect;)V");
			global::android.graphics.Rect._sort3677 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "sort", "()V");
			global::android.graphics.Rect._intersects3678 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Rect.staticClass, "intersects", "(Landroid/graphics/Rect;Landroid/graphics/Rect;)Z");
			global::android.graphics.Rect._intersects3679 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "intersects", "(IIII)Z");
			global::android.graphics.Rect._union3680 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "union", "(II)V");
			global::android.graphics.Rect._union3681 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "union", "(IIII)V");
			global::android.graphics.Rect._union3682 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "union", "(Landroid/graphics/Rect;)V");
			global::android.graphics.Rect._centerX3683 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "centerX", "()I");
			global::android.graphics.Rect._centerY3684 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "centerY", "()I");
			global::android.graphics.Rect._height3685 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "height", "()I");
			global::android.graphics.Rect._width3686 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "width", "()I");
			global::android.graphics.Rect._writeToParcel3687 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.graphics.Rect._describeContents3688 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "describeContents", "()I");
			global::android.graphics.Rect._readFromParcel3689 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
			global::android.graphics.Rect._flattenToString3690 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "flattenToString", "()Ljava/lang/String;");
			global::android.graphics.Rect._unflattenFromString3691 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Rect.staticClass, "unflattenFromString", "(Ljava/lang/String;)Landroid/graphics/Rect;");
			global::android.graphics.Rect._toShortString3692 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "toShortString", "()Ljava/lang/String;");
			global::android.graphics.Rect._setEmpty3693 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "setEmpty", "()V");
			global::android.graphics.Rect._exactCenterX3694 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "exactCenterX", "()F");
			global::android.graphics.Rect._exactCenterY3695 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "exactCenterY", "()F");
			global::android.graphics.Rect._offsetTo3696 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "offsetTo", "(II)V");
			global::android.graphics.Rect._inset3697 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "inset", "(II)V");
			global::android.graphics.Rect._intersect3698 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "intersect", "(IIII)Z");
			global::android.graphics.Rect._intersect3699 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "intersect", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.Rect._setIntersect3700 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "setIntersect", "(Landroid/graphics/Rect;Landroid/graphics/Rect;)Z");
			global::android.graphics.Rect._Rect3701 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "<init>", "()V");
			global::android.graphics.Rect._Rect3702 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "<init>", "(IIII)V");
			global::android.graphics.Rect._Rect3703 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "<init>", "(Landroid/graphics/Rect;)V");
		}
	}
}
