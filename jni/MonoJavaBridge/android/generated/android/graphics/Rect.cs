namespace android.graphics
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class Rect : java.lang.Object, android.os.Parcelable
	{
		internal static global::java.lang.Class staticClass;
		static Rect()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.Rect), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.graphics.Rect(@__env);
			}
		}
		internal Rect(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals3481;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Rect._equals3481, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._equals3481, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString3482;
		public sealed override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Rect._toString3482));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._toString3482));
		}
		internal static global::net.sf.jni4net.jni.MethodId _offset3483;
		public void offset(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Rect._offset3483, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._offset3483, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty3484;
		public bool isEmpty() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Rect._isEmpty3484);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._isEmpty3484);
		}
		internal static global::net.sf.jni4net.jni.MethodId _contains3485;
		public bool contains(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Rect._contains3485, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._contains3485, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _contains3486;
		public bool contains(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Rect._contains3486, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._contains3486, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _contains3487;
		public bool contains(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Rect._contains3487, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._contains3487, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _set3488;
		public void set(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Rect._set3488, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._set3488, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _set3489;
		public void set(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Rect._set3489, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._set3489, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sort3490;
		public void sort() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Rect._sort3490);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._sort3490);
		}
		internal static global::net.sf.jni4net.jni.MethodId _intersects3491;
		public static bool intersects(android.graphics.Rect arg0, android.graphics.Rect arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.graphics.Rect.staticClass, global::android.graphics.Rect._intersects3491, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _intersects3492;
		public bool intersects(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Rect._intersects3492, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._intersects3492, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _union3493;
		public void union(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Rect._union3493, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._union3493, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _union3494;
		public void union(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Rect._union3494, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._union3494, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _union3495;
		public void union(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Rect._union3495, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._union3495, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _centerX3496;
		public int centerX() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.Rect._centerX3496);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._centerX3496);
		}
		internal static global::net.sf.jni4net.jni.MethodId _centerY3497;
		public int centerY() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.Rect._centerY3497);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._centerY3497);
		}
		internal static global::net.sf.jni4net.jni.MethodId _height3498;
		public int height() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.Rect._height3498);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._height3498);
		}
		internal static global::net.sf.jni4net.jni.MethodId _width3499;
		public int width() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.Rect._width3499);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._width3499);
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel3500;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Rect._writeToParcel3500, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._writeToParcel3500, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents3501;
		public int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.Rect._describeContents3501);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._describeContents3501);
		}
		internal static global::net.sf.jni4net.jni.MethodId _readFromParcel3502;
		public void readFromParcel(android.os.Parcel arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Rect._readFromParcel3502, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._readFromParcel3502, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _flattenToString3503;
		public global::java.lang.String flattenToString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Rect._flattenToString3503));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._flattenToString3503));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unflattenFromString3504;
		public static global::android.graphics.Rect unflattenFromString(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Rect>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Rect.staticClass, global::android.graphics.Rect._unflattenFromString3504, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toShortString3505;
		public global::java.lang.String toShortString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Rect._toShortString3505));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._toShortString3505));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setEmpty3506;
		public void setEmpty() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Rect._setEmpty3506);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._setEmpty3506);
		}
		internal static global::net.sf.jni4net.jni.MethodId _exactCenterX3507;
		public float exactCenterX() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.graphics.Rect._exactCenterX3507);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._exactCenterX3507);
		}
		internal static global::net.sf.jni4net.jni.MethodId _exactCenterY3508;
		public float exactCenterY() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.graphics.Rect._exactCenterY3508);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._exactCenterY3508);
		}
		internal static global::net.sf.jni4net.jni.MethodId _offsetTo3509;
		public void offsetTo(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Rect._offsetTo3509, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._offsetTo3509, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _inset3510;
		public void inset(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Rect._inset3510, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._inset3510, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _intersect3511;
		public bool intersect(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Rect._intersect3511, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._intersect3511, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _intersect3512;
		public bool intersect(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Rect._intersect3512, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._intersect3512, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setIntersect3513;
		public bool setIntersect(android.graphics.Rect arg0, android.graphics.Rect arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Rect._setIntersect3513, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._setIntersect3513, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Rect3514;
		public Rect()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.Rect.staticClass, global::android.graphics.Rect._Rect3514, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _Rect3515;
		public Rect(int arg0, int arg1, int arg2, int arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.Rect.staticClass, global::android.graphics.Rect._Rect3515, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Rect3516;
		public Rect(android.graphics.Rect arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.Rect.staticClass, global::android.graphics.Rect._Rect3516, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.FieldId _left3517;
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
		internal static global::net.sf.jni4net.jni.FieldId _top3518;
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
		internal static global::net.sf.jni4net.jni.FieldId _right3519;
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
		internal static global::net.sf.jni4net.jni.FieldId _bottom3520;
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
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR3521;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.graphics.Rect.staticClass = @__class;
			global::android.graphics.Rect._equals3481 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.graphics.Rect._toString3482 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "toString", "()Ljava/lang/String;");
			global::android.graphics.Rect._offset3483 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "offset", "(II)V");
			global::android.graphics.Rect._isEmpty3484 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "isEmpty", "()Z");
			global::android.graphics.Rect._contains3485 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "contains", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.Rect._contains3486 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "contains", "(IIII)Z");
			global::android.graphics.Rect._contains3487 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "contains", "(II)Z");
			global::android.graphics.Rect._set3488 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "set", "(IIII)V");
			global::android.graphics.Rect._set3489 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "set", "(Landroid/graphics/Rect;)V");
			global::android.graphics.Rect._sort3490 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "sort", "()V");
			global::android.graphics.Rect._intersects3491 = @__env.GetStaticMethodID(global::android.graphics.Rect.staticClass, "intersects", "(Landroid/graphics/Rect;Landroid/graphics/Rect;)Z");
			global::android.graphics.Rect._intersects3492 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "intersects", "(IIII)Z");
			global::android.graphics.Rect._union3493 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "union", "(II)V");
			global::android.graphics.Rect._union3494 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "union", "(IIII)V");
			global::android.graphics.Rect._union3495 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "union", "(Landroid/graphics/Rect;)V");
			global::android.graphics.Rect._centerX3496 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "centerX", "()I");
			global::android.graphics.Rect._centerY3497 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "centerY", "()I");
			global::android.graphics.Rect._height3498 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "height", "()I");
			global::android.graphics.Rect._width3499 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "width", "()I");
			global::android.graphics.Rect._writeToParcel3500 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.graphics.Rect._describeContents3501 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "describeContents", "()I");
			global::android.graphics.Rect._readFromParcel3502 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
			global::android.graphics.Rect._flattenToString3503 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "flattenToString", "()Ljava/lang/String;");
			global::android.graphics.Rect._unflattenFromString3504 = @__env.GetStaticMethodID(global::android.graphics.Rect.staticClass, "unflattenFromString", "(Ljava/lang/String;)Landroid/graphics/Rect;");
			global::android.graphics.Rect._toShortString3505 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "toShortString", "()Ljava/lang/String;");
			global::android.graphics.Rect._setEmpty3506 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "setEmpty", "()V");
			global::android.graphics.Rect._exactCenterX3507 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "exactCenterX", "()F");
			global::android.graphics.Rect._exactCenterY3508 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "exactCenterY", "()F");
			global::android.graphics.Rect._offsetTo3509 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "offsetTo", "(II)V");
			global::android.graphics.Rect._inset3510 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "inset", "(II)V");
			global::android.graphics.Rect._intersect3511 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "intersect", "(IIII)Z");
			global::android.graphics.Rect._intersect3512 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "intersect", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.Rect._setIntersect3513 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "setIntersect", "(Landroid/graphics/Rect;Landroid/graphics/Rect;)Z");
			global::android.graphics.Rect._Rect3514 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "<init>", "()V");
			global::android.graphics.Rect._Rect3515 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "<init>", "(IIII)V");
			global::android.graphics.Rect._Rect3516 = @__env.GetMethodID(global::android.graphics.Rect.staticClass, "<init>", "(Landroid/graphics/Rect;)V");
		}
	}
}
