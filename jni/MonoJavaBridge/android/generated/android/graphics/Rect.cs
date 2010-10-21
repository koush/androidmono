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
		internal static global::MonoJavaBridge.MethodId _equals5649;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Rect._equals5649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._equals5649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString5650;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Rect._toString5650)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._toString5650)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _offset5651;
		public void offset(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Rect._offset5651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._offset5651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty5652;
		public bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Rect._isEmpty5652);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._isEmpty5652);
		}
		internal static global::MonoJavaBridge.MethodId _contains5653;
		public bool contains(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Rect._contains5653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._contains5653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _contains5654;
		public bool contains(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Rect._contains5654, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._contains5654, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _contains5655;
		public bool contains(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Rect._contains5655, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._contains5655, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _set5656;
		public void set(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Rect._set5656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._set5656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _set5657;
		public void set(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Rect._set5657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._set5657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sort5658;
		public void sort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Rect._sort5658);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._sort5658);
		}
		internal static global::MonoJavaBridge.MethodId _intersects5659;
		public static bool intersects(android.graphics.Rect arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.graphics.Rect.staticClass, global::android.graphics.Rect._intersects5659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _intersects5660;
		public bool intersects(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Rect._intersects5660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._intersects5660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _union5661;
		public void union(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Rect._union5661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._union5661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _union5662;
		public void union(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Rect._union5662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._union5662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _union5663;
		public void union(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Rect._union5663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._union5663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _centerX5664;
		public int centerX() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Rect._centerX5664);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._centerX5664);
		}
		internal static global::MonoJavaBridge.MethodId _centerY5665;
		public int centerY() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Rect._centerY5665);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._centerY5665);
		}
		internal static global::MonoJavaBridge.MethodId _height5666;
		public int height() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Rect._height5666);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._height5666);
		}
		internal static global::MonoJavaBridge.MethodId _width5667;
		public int width() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Rect._width5667);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._width5667);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel5668;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Rect._writeToParcel5668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._writeToParcel5668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents5669;
		public int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Rect._describeContents5669);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._describeContents5669);
		}
		internal static global::MonoJavaBridge.MethodId _readFromParcel5670;
		public void readFromParcel(android.os.Parcel arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Rect._readFromParcel5670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._readFromParcel5670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _flattenToString5671;
		public global::java.lang.String flattenToString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Rect._flattenToString5671)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._flattenToString5671)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _unflattenFromString5672;
		public static global::android.graphics.Rect unflattenFromString(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Rect.staticClass, global::android.graphics.Rect._unflattenFromString5672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Rect;
		}
		internal static global::MonoJavaBridge.MethodId _toShortString5673;
		public global::java.lang.String toShortString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Rect._toShortString5673)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._toShortString5673)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setEmpty5674;
		public void setEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Rect._setEmpty5674);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._setEmpty5674);
		}
		internal static global::MonoJavaBridge.MethodId _exactCenterX5675;
		public float exactCenterX() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.Rect._exactCenterX5675);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._exactCenterX5675);
		}
		internal static global::MonoJavaBridge.MethodId _exactCenterY5676;
		public float exactCenterY() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.Rect._exactCenterY5676);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._exactCenterY5676);
		}
		internal static global::MonoJavaBridge.MethodId _offsetTo5677;
		public void offsetTo(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Rect._offsetTo5677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._offsetTo5677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _inset5678;
		public void inset(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Rect._inset5678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._inset5678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _intersect5679;
		public bool intersect(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Rect._intersect5679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._intersect5679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _intersect5680;
		public bool intersect(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Rect._intersect5680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._intersect5680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIntersect5681;
		public bool setIntersect(android.graphics.Rect arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Rect._setIntersect5681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._setIntersect5681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _Rect5682;
		public Rect()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Rect.staticClass, global::android.graphics.Rect._Rect5682);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Rect5683;
		public Rect(int arg0, int arg1, int arg2, int arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Rect.staticClass, global::android.graphics.Rect._Rect5683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Rect5684;
		public Rect(android.graphics.Rect arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Rect.staticClass, global::android.graphics.Rect._Rect5684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _left5685;
		public int left
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _left5685);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _top5686;
		public int top
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _top5686);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _right5687;
		public int right
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _right5687);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _bottom5688;
		public int bottom
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _bottom5688);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR5689;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.graphics.Rect.staticClass, _CREATOR5689)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Rect.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Rect"));
			global::android.graphics.Rect._equals5649 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.graphics.Rect._toString5650 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "toString", "()Ljava/lang/String;");
			global::android.graphics.Rect._offset5651 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "offset", "(II)V");
			global::android.graphics.Rect._isEmpty5652 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "isEmpty", "()Z");
			global::android.graphics.Rect._contains5653 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "contains", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.Rect._contains5654 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "contains", "(IIII)Z");
			global::android.graphics.Rect._contains5655 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "contains", "(II)Z");
			global::android.graphics.Rect._set5656 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "set", "(IIII)V");
			global::android.graphics.Rect._set5657 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "set", "(Landroid/graphics/Rect;)V");
			global::android.graphics.Rect._sort5658 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "sort", "()V");
			global::android.graphics.Rect._intersects5659 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Rect.staticClass, "intersects", "(Landroid/graphics/Rect;Landroid/graphics/Rect;)Z");
			global::android.graphics.Rect._intersects5660 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "intersects", "(IIII)Z");
			global::android.graphics.Rect._union5661 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "union", "(II)V");
			global::android.graphics.Rect._union5662 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "union", "(IIII)V");
			global::android.graphics.Rect._union5663 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "union", "(Landroid/graphics/Rect;)V");
			global::android.graphics.Rect._centerX5664 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "centerX", "()I");
			global::android.graphics.Rect._centerY5665 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "centerY", "()I");
			global::android.graphics.Rect._height5666 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "height", "()I");
			global::android.graphics.Rect._width5667 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "width", "()I");
			global::android.graphics.Rect._writeToParcel5668 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.graphics.Rect._describeContents5669 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "describeContents", "()I");
			global::android.graphics.Rect._readFromParcel5670 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
			global::android.graphics.Rect._flattenToString5671 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "flattenToString", "()Ljava/lang/String;");
			global::android.graphics.Rect._unflattenFromString5672 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Rect.staticClass, "unflattenFromString", "(Ljava/lang/String;)Landroid/graphics/Rect;");
			global::android.graphics.Rect._toShortString5673 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "toShortString", "()Ljava/lang/String;");
			global::android.graphics.Rect._setEmpty5674 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "setEmpty", "()V");
			global::android.graphics.Rect._exactCenterX5675 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "exactCenterX", "()F");
			global::android.graphics.Rect._exactCenterY5676 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "exactCenterY", "()F");
			global::android.graphics.Rect._offsetTo5677 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "offsetTo", "(II)V");
			global::android.graphics.Rect._inset5678 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "inset", "(II)V");
			global::android.graphics.Rect._intersect5679 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "intersect", "(IIII)Z");
			global::android.graphics.Rect._intersect5680 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "intersect", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.Rect._setIntersect5681 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "setIntersect", "(Landroid/graphics/Rect;Landroid/graphics/Rect;)Z");
			global::android.graphics.Rect._Rect5682 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "<init>", "()V");
			global::android.graphics.Rect._Rect5683 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "<init>", "(IIII)V");
			global::android.graphics.Rect._Rect5684 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "<init>", "(Landroid/graphics/Rect;)V");
			global::android.graphics.Rect._left5685 = @__env.GetFieldIDNoThrow(global::android.graphics.Rect.staticClass, "left", "I");
			global::android.graphics.Rect._top5686 = @__env.GetFieldIDNoThrow(global::android.graphics.Rect.staticClass, "top", "I");
			global::android.graphics.Rect._right5687 = @__env.GetFieldIDNoThrow(global::android.graphics.Rect.staticClass, "right", "I");
			global::android.graphics.Rect._bottom5688 = @__env.GetFieldIDNoThrow(global::android.graphics.Rect.staticClass, "bottom", "I");
			global::android.graphics.Rect._CREATOR5689 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Rect.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
