namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class ContentValues : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ContentValues()
		{
			InitJNI();
		}
		internal ContentValues(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get2767;
		public global::java.lang.Object get(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentValues._get2767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._get2767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put2768;
		public void put(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContentValues._put2768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._put2768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _put2769;
		public void put(java.lang.String arg0, java.lang.Byte arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContentValues._put2769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._put2769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _put2770;
		public void put(java.lang.String arg0, java.lang.Short arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContentValues._put2770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._put2770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _put2771;
		public void put(java.lang.String arg0, java.lang.Integer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContentValues._put2771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._put2771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _put2772;
		public void put(java.lang.String arg0, java.lang.Long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContentValues._put2772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._put2772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _put2773;
		public void put(java.lang.String arg0, java.lang.Boolean arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContentValues._put2773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._put2773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _put2774;
		public void put(java.lang.String arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContentValues._put2774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._put2774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _put2775;
		public void put(java.lang.String arg0, java.lang.Float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContentValues._put2775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._put2775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _put2776;
		public void put(java.lang.String arg0, java.lang.Double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContentValues._put2776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._put2776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _equals2777;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.ContentValues._equals2777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._equals2777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString2778;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentValues._toString2778)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._toString2778)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode2779;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.ContentValues._hashCode2779);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._hashCode2779);
		}
		internal static global::MonoJavaBridge.MethodId _clear2780;
		public void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContentValues._clear2780);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._clear2780);
		}
		internal static global::MonoJavaBridge.MethodId _size2781;
		public int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.ContentValues._size2781);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._size2781);
		}
		internal static global::MonoJavaBridge.MethodId _putAll2782;
		public void putAll(android.content.ContentValues arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContentValues._putAll2782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._putAll2782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove2783;
		public void remove(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContentValues._remove2783, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._remove2783, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsKey2784;
		public bool containsKey(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.ContentValues._containsKey2784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._containsKey2784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAsString2785;
		public global::java.lang.String getAsString(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentValues._getAsString2785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._getAsString2785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _putNull2786;
		public void putNull(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContentValues._putNull2786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._putNull2786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel2787;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContentValues._writeToParcel2787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._writeToParcel2787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents2788;
		public int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.ContentValues._describeContents2788);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._describeContents2788);
		}
		internal static global::MonoJavaBridge.MethodId _getAsLong2789;
		public global::java.lang.Long getAsLong(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentValues._getAsLong2789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Long;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._getAsLong2789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Long;
		}
		internal static global::MonoJavaBridge.MethodId _getAsInteger2790;
		public global::java.lang.Integer getAsInteger(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentValues._getAsInteger2790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Integer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._getAsInteger2790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Integer;
		}
		internal static global::MonoJavaBridge.MethodId _getAsShort2791;
		public global::java.lang.Short getAsShort(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentValues._getAsShort2791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Short;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._getAsShort2791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Short;
		}
		internal static global::MonoJavaBridge.MethodId _getAsByte2792;
		public global::java.lang.Byte getAsByte(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentValues._getAsByte2792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Byte;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._getAsByte2792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Byte;
		}
		internal static global::MonoJavaBridge.MethodId _getAsDouble2793;
		public global::java.lang.Double getAsDouble(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentValues._getAsDouble2793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Double;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._getAsDouble2793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Double;
		}
		internal static global::MonoJavaBridge.MethodId _getAsFloat2794;
		public global::java.lang.Float getAsFloat(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentValues._getAsFloat2794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Float;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._getAsFloat2794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Float;
		}
		internal static global::MonoJavaBridge.MethodId _getAsBoolean2795;
		public global::java.lang.Boolean getAsBoolean(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentValues._getAsBoolean2795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Boolean;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._getAsBoolean2795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Boolean;
		}
		internal static global::MonoJavaBridge.MethodId _getAsByteArray2796;
		public byte[] getAsByteArray(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentValues._getAsByteArray2796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._getAsByteArray2796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _valueSet2797;
		public global::java.util.Set valueSet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentValues._valueSet2797)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._valueSet2797)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _ContentValues2798;
		public ContentValues()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ContentValues.staticClass, global::android.content.ContentValues._ContentValues2798);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ContentValues2799;
		public ContentValues(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ContentValues.staticClass, global::android.content.ContentValues._ContentValues2799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ContentValues2800;
		public ContentValues(android.content.ContentValues arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ContentValues.staticClass, global::android.content.ContentValues._ContentValues2800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static global::java.lang.String TAG
		{
			get
			{
				return "ContentValues";
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR2802;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.ContentValues.staticClass, _CREATOR2802)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.ContentValues.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/ContentValues"));
			global::android.content.ContentValues._get2767 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "get", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::android.content.ContentValues._put2768 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.content.ContentValues._put2769 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Byte;)V");
			global::android.content.ContentValues._put2770 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Short;)V");
			global::android.content.ContentValues._put2771 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Integer;)V");
			global::android.content.ContentValues._put2772 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Long;)V");
			global::android.content.ContentValues._put2773 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Boolean;)V");
			global::android.content.ContentValues._put2774 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;[B)V");
			global::android.content.ContentValues._put2775 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Float;)V");
			global::android.content.ContentValues._put2776 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Double;)V");
			global::android.content.ContentValues._equals2777 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.content.ContentValues._toString2778 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.ContentValues._hashCode2779 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "hashCode", "()I");
			global::android.content.ContentValues._clear2780 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "clear", "()V");
			global::android.content.ContentValues._size2781 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "size", "()I");
			global::android.content.ContentValues._putAll2782 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "putAll", "(Landroid/content/ContentValues;)V");
			global::android.content.ContentValues._remove2783 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "remove", "(Ljava/lang/String;)V");
			global::android.content.ContentValues._containsKey2784 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "containsKey", "(Ljava/lang/String;)Z");
			global::android.content.ContentValues._getAsString2785 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "getAsString", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.content.ContentValues._putNull2786 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "putNull", "(Ljava/lang/String;)V");
			global::android.content.ContentValues._writeToParcel2787 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.ContentValues._describeContents2788 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "describeContents", "()I");
			global::android.content.ContentValues._getAsLong2789 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "getAsLong", "(Ljava/lang/String;)Ljava/lang/Long;");
			global::android.content.ContentValues._getAsInteger2790 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "getAsInteger", "(Ljava/lang/String;)Ljava/lang/Integer;");
			global::android.content.ContentValues._getAsShort2791 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "getAsShort", "(Ljava/lang/String;)Ljava/lang/Short;");
			global::android.content.ContentValues._getAsByte2792 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "getAsByte", "(Ljava/lang/String;)Ljava/lang/Byte;");
			global::android.content.ContentValues._getAsDouble2793 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "getAsDouble", "(Ljava/lang/String;)Ljava/lang/Double;");
			global::android.content.ContentValues._getAsFloat2794 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "getAsFloat", "(Ljava/lang/String;)Ljava/lang/Float;");
			global::android.content.ContentValues._getAsBoolean2795 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "getAsBoolean", "(Ljava/lang/String;)Ljava/lang/Boolean;");
			global::android.content.ContentValues._getAsByteArray2796 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "getAsByteArray", "(Ljava/lang/String;)[B");
			global::android.content.ContentValues._valueSet2797 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "valueSet", "()Ljava/util/Set;");
			global::android.content.ContentValues._ContentValues2798 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "<init>", "()V");
			global::android.content.ContentValues._ContentValues2799 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "<init>", "(I)V");
			global::android.content.ContentValues._ContentValues2800 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "<init>", "(Landroid/content/ContentValues;)V");
			global::android.content.ContentValues._CREATOR2802 = @__env.GetStaticFieldIDNoThrow(global::android.content.ContentValues.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
