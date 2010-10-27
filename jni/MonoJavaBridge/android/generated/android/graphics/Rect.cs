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
		internal static global::MonoJavaBridge.MethodId _equals5668;
		public sealed override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Rect._equals5668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._equals5668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString5669;
		public sealed override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Rect._toString5669)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._toString5669)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _offset5670;
		public void offset(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Rect._offset5670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._offset5670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty5671;
		public bool isEmpty()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Rect._isEmpty5671);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._isEmpty5671);
		}
		internal static global::MonoJavaBridge.MethodId _contains5672;
		public bool contains(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Rect._contains5672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._contains5672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _contains5673;
		public bool contains(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Rect._contains5673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._contains5673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _contains5674;
		public bool contains(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Rect._contains5674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._contains5674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _set5675;
		public void set(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Rect._set5675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._set5675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _set5676;
		public void set(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Rect._set5676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._set5676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sort5677;
		public void sort()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Rect._sort5677);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._sort5677);
		}
		internal static global::MonoJavaBridge.MethodId _intersects5678;
		public static bool intersects(android.graphics.Rect arg0, android.graphics.Rect arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.graphics.Rect.staticClass, global::android.graphics.Rect._intersects5678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _intersects5679;
		public bool intersects(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Rect._intersects5679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._intersects5679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _union5680;
		public void union(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Rect._union5680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._union5680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _union5681;
		public void union(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Rect._union5681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._union5681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _union5682;
		public void union(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Rect._union5682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._union5682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _centerX5683;
		public int centerX()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Rect._centerX5683);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._centerX5683);
		}
		internal static global::MonoJavaBridge.MethodId _centerY5684;
		public int centerY()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Rect._centerY5684);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._centerY5684);
		}
		internal static global::MonoJavaBridge.MethodId _height5685;
		public int height()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Rect._height5685);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._height5685);
		}
		internal static global::MonoJavaBridge.MethodId _width5686;
		public int width()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Rect._width5686);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._width5686);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel5687;
		public void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Rect._writeToParcel5687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._writeToParcel5687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents5688;
		public int describeContents()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Rect._describeContents5688);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._describeContents5688);
		}
		internal static global::MonoJavaBridge.MethodId _readFromParcel5689;
		public void readFromParcel(android.os.Parcel arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Rect._readFromParcel5689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._readFromParcel5689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _flattenToString5690;
		public global::java.lang.String flattenToString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Rect._flattenToString5690)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._flattenToString5690)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _unflattenFromString5691;
		public static global::android.graphics.Rect unflattenFromString(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Rect>(@__env.CallStaticObjectMethod(android.graphics.Rect.staticClass, global::android.graphics.Rect._unflattenFromString5691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Rect;
		}
		internal static global::MonoJavaBridge.MethodId _toShortString5692;
		public global::java.lang.String toShortString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Rect._toShortString5692)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._toShortString5692)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setEmpty5693;
		public void setEmpty()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Rect._setEmpty5693);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._setEmpty5693);
		}
		internal static global::MonoJavaBridge.MethodId _exactCenterX5694;
		public float exactCenterX()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.Rect._exactCenterX5694);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._exactCenterX5694);
		}
		internal static global::MonoJavaBridge.MethodId _exactCenterY5695;
		public float exactCenterY()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.Rect._exactCenterY5695);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._exactCenterY5695);
		}
		internal static global::MonoJavaBridge.MethodId _offsetTo5696;
		public void offsetTo(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Rect._offsetTo5696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._offsetTo5696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _inset5697;
		public void inset(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Rect._inset5697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._inset5697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _intersect5698;
		public bool intersect(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Rect._intersect5698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._intersect5698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _intersect5699;
		public bool intersect(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Rect._intersect5699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._intersect5699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIntersect5700;
		public bool setIntersect(android.graphics.Rect arg0, android.graphics.Rect arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Rect._setIntersect5700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Rect.staticClass, global::android.graphics.Rect._setIntersect5700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _Rect5701;
		public Rect() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Rect.staticClass, global::android.graphics.Rect._Rect5701);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Rect5702;
		public Rect(int arg0, int arg1, int arg2, int arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Rect.staticClass, global::android.graphics.Rect._Rect5702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Rect5703;
		public Rect(android.graphics.Rect arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Rect.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Rect"));
			global::android.graphics.Rect._equals5668 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.graphics.Rect._toString5669 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "toString", "()Ljava/lang/String;");
			global::android.graphics.Rect._offset5670 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "offset", "(II)V");
			global::android.graphics.Rect._isEmpty5671 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "isEmpty", "()Z");
			global::android.graphics.Rect._contains5672 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "contains", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.Rect._contains5673 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "contains", "(IIII)Z");
			global::android.graphics.Rect._contains5674 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "contains", "(II)Z");
			global::android.graphics.Rect._set5675 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "set", "(IIII)V");
			global::android.graphics.Rect._set5676 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "set", "(Landroid/graphics/Rect;)V");
			global::android.graphics.Rect._sort5677 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "sort", "()V");
			global::android.graphics.Rect._intersects5678 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Rect.staticClass, "intersects", "(Landroid/graphics/Rect;Landroid/graphics/Rect;)Z");
			global::android.graphics.Rect._intersects5679 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "intersects", "(IIII)Z");
			global::android.graphics.Rect._union5680 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "union", "(II)V");
			global::android.graphics.Rect._union5681 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "union", "(IIII)V");
			global::android.graphics.Rect._union5682 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "union", "(Landroid/graphics/Rect;)V");
			global::android.graphics.Rect._centerX5683 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "centerX", "()I");
			global::android.graphics.Rect._centerY5684 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "centerY", "()I");
			global::android.graphics.Rect._height5685 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "height", "()I");
			global::android.graphics.Rect._width5686 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "width", "()I");
			global::android.graphics.Rect._writeToParcel5687 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.graphics.Rect._describeContents5688 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "describeContents", "()I");
			global::android.graphics.Rect._readFromParcel5689 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
			global::android.graphics.Rect._flattenToString5690 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "flattenToString", "()Ljava/lang/String;");
			global::android.graphics.Rect._unflattenFromString5691 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Rect.staticClass, "unflattenFromString", "(Ljava/lang/String;)Landroid/graphics/Rect;");
			global::android.graphics.Rect._toShortString5692 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "toShortString", "()Ljava/lang/String;");
			global::android.graphics.Rect._setEmpty5693 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "setEmpty", "()V");
			global::android.graphics.Rect._exactCenterX5694 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "exactCenterX", "()F");
			global::android.graphics.Rect._exactCenterY5695 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "exactCenterY", "()F");
			global::android.graphics.Rect._offsetTo5696 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "offsetTo", "(II)V");
			global::android.graphics.Rect._inset5697 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "inset", "(II)V");
			global::android.graphics.Rect._intersect5698 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "intersect", "(IIII)Z");
			global::android.graphics.Rect._intersect5699 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "intersect", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.Rect._setIntersect5700 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "setIntersect", "(Landroid/graphics/Rect;Landroid/graphics/Rect;)Z");
			global::android.graphics.Rect._Rect5701 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "<init>", "()V");
			global::android.graphics.Rect._Rect5702 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "<init>", "(IIII)V");
			global::android.graphics.Rect._Rect5703 = @__env.GetMethodIDNoThrow(global::android.graphics.Rect.staticClass, "<init>", "(Landroid/graphics/Rect;)V");
			global::android.graphics.Rect._left5704 = @__env.GetFieldIDNoThrow(global::android.graphics.Rect.staticClass, "left", "I");
			global::android.graphics.Rect._top5705 = @__env.GetFieldIDNoThrow(global::android.graphics.Rect.staticClass, "top", "I");
			global::android.graphics.Rect._right5706 = @__env.GetFieldIDNoThrow(global::android.graphics.Rect.staticClass, "right", "I");
			global::android.graphics.Rect._bottom5707 = @__env.GetFieldIDNoThrow(global::android.graphics.Rect.staticClass, "bottom", "I");
			global::android.graphics.Rect._CREATOR5708 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Rect.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
