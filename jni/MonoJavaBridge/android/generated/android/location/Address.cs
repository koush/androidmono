namespace android.location
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Address : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Address()
		{
			InitJNI();
		}
		protected Address(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString6770;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.location.Address._toString6770)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._toString6770)) as java.lang.String;
		}
		public new global::java.lang.String Locality
		{
			get
			{
				return getLocality();
			}
			set
			{
				setLocality(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocality6771;
		public virtual global::java.lang.String getLocality() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.location.Address._getLocality6771)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._getLocality6771)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel6772;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Address._writeToParcel6772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._writeToParcel6772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents6773;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.location.Address._describeContents6773);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._describeContents6773);
		}
		public new global::android.os.Bundle Extras
		{
			get
			{
				return getExtras();
			}
			set
			{
				setExtras(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getExtras6774;
		public virtual global::android.os.Bundle getExtras() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallObjectMethod(this.JvmHandle, global::android.location.Address._getExtras6774)) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._getExtras6774)) as android.os.Bundle;
		}
		public new global::java.util.Locale Locale
		{
			get
			{
				return getLocale();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocale6775;
		public virtual global::java.util.Locale getLocale() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.CallObjectMethod(this.JvmHandle, global::android.location.Address._getLocale6775)) as java.util.Locale;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._getLocale6775)) as java.util.Locale;
		}
		public new int MaxAddressLineIndex
		{
			get
			{
				return getMaxAddressLineIndex();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMaxAddressLineIndex6776;
		public virtual int getMaxAddressLineIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.location.Address._getMaxAddressLineIndex6776);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._getMaxAddressLineIndex6776);
		}
		internal static global::MonoJavaBridge.MethodId _getAddressLine6777;
		public virtual global::java.lang.String getAddressLine(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.location.Address._getAddressLine6777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._getAddressLine6777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setAddressLine6778;
		public virtual void setAddressLine(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Address._setAddressLine6778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._setAddressLine6778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.lang.String FeatureName
		{
			get
			{
				return getFeatureName();
			}
			set
			{
				setFeatureName(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFeatureName6779;
		public virtual global::java.lang.String getFeatureName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.location.Address._getFeatureName6779)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._getFeatureName6779)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setFeatureName6780;
		public virtual void setFeatureName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Address._setFeatureName6780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._setFeatureName6780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String AdminArea
		{
			get
			{
				return getAdminArea();
			}
			set
			{
				setAdminArea(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAdminArea6781;
		public virtual global::java.lang.String getAdminArea() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.location.Address._getAdminArea6781)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._getAdminArea6781)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setAdminArea6782;
		public virtual void setAdminArea(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Address._setAdminArea6782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._setAdminArea6782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String SubAdminArea
		{
			get
			{
				return getSubAdminArea();
			}
			set
			{
				setSubAdminArea(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSubAdminArea6783;
		public virtual global::java.lang.String getSubAdminArea() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.location.Address._getSubAdminArea6783)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._getSubAdminArea6783)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setSubAdminArea6784;
		public virtual void setSubAdminArea(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Address._setSubAdminArea6784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._setSubAdminArea6784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLocality6785;
		public virtual void setLocality(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Address._setLocality6785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._setLocality6785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String SubLocality
		{
			get
			{
				return getSubLocality();
			}
			set
			{
				setSubLocality(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSubLocality6786;
		public virtual global::java.lang.String getSubLocality() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.location.Address._getSubLocality6786)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._getSubLocality6786)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setSubLocality6787;
		public virtual void setSubLocality(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Address._setSubLocality6787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._setSubLocality6787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Thoroughfare
		{
			get
			{
				return getThoroughfare();
			}
			set
			{
				setThoroughfare(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getThoroughfare6788;
		public virtual global::java.lang.String getThoroughfare() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.location.Address._getThoroughfare6788)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._getThoroughfare6788)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setThoroughfare6789;
		public virtual void setThoroughfare(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Address._setThoroughfare6789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._setThoroughfare6789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String SubThoroughfare
		{
			get
			{
				return getSubThoroughfare();
			}
			set
			{
				setSubThoroughfare(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSubThoroughfare6790;
		public virtual global::java.lang.String getSubThoroughfare() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.location.Address._getSubThoroughfare6790)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._getSubThoroughfare6790)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setSubThoroughfare6791;
		public virtual void setSubThoroughfare(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Address._setSubThoroughfare6791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._setSubThoroughfare6791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Premises
		{
			get
			{
				return getPremises();
			}
			set
			{
				setPremises(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPremises6792;
		public virtual global::java.lang.String getPremises() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.location.Address._getPremises6792)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._getPremises6792)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setPremises6793;
		public virtual void setPremises(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Address._setPremises6793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._setPremises6793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String PostalCode
		{
			get
			{
				return getPostalCode();
			}
			set
			{
				setPostalCode(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPostalCode6794;
		public virtual global::java.lang.String getPostalCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.location.Address._getPostalCode6794)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._getPostalCode6794)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setPostalCode6795;
		public virtual void setPostalCode(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Address._setPostalCode6795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._setPostalCode6795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String CountryCode
		{
			get
			{
				return getCountryCode();
			}
			set
			{
				setCountryCode(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCountryCode6796;
		public virtual global::java.lang.String getCountryCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.location.Address._getCountryCode6796)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._getCountryCode6796)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setCountryCode6797;
		public virtual void setCountryCode(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Address._setCountryCode6797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._setCountryCode6797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String CountryName
		{
			get
			{
				return getCountryName();
			}
			set
			{
				setCountryName(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCountryName6798;
		public virtual global::java.lang.String getCountryName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.location.Address._getCountryName6798)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._getCountryName6798)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setCountryName6799;
		public virtual void setCountryName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Address._setCountryName6799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._setCountryName6799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasLatitude6800;
		public virtual bool hasLatitude() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.Address._hasLatitude6800);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._hasLatitude6800);
		}
		public new double Latitude
		{
			get
			{
				return getLatitude();
			}
			set
			{
				setLatitude(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLatitude6801;
		public virtual double getLatitude() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::android.location.Address._getLatitude6801);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._getLatitude6801);
		}
		internal static global::MonoJavaBridge.MethodId _setLatitude6802;
		public virtual void setLatitude(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Address._setLatitude6802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._setLatitude6802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearLatitude6803;
		public virtual void clearLatitude() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Address._clearLatitude6803);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._clearLatitude6803);
		}
		internal static global::MonoJavaBridge.MethodId _hasLongitude6804;
		public virtual bool hasLongitude() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.Address._hasLongitude6804);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._hasLongitude6804);
		}
		public new double Longitude
		{
			get
			{
				return getLongitude();
			}
			set
			{
				setLongitude(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLongitude6805;
		public virtual double getLongitude() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::android.location.Address._getLongitude6805);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._getLongitude6805);
		}
		internal static global::MonoJavaBridge.MethodId _setLongitude6806;
		public virtual void setLongitude(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Address._setLongitude6806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._setLongitude6806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearLongitude6807;
		public virtual void clearLongitude() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Address._clearLongitude6807);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._clearLongitude6807);
		}
		public new global::java.lang.String Phone
		{
			get
			{
				return getPhone();
			}
			set
			{
				setPhone(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPhone6808;
		public virtual global::java.lang.String getPhone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.location.Address._getPhone6808)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._getPhone6808)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setPhone6809;
		public virtual void setPhone(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Address._setPhone6809, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._setPhone6809, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Url
		{
			get
			{
				return getUrl();
			}
			set
			{
				setUrl(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUrl6810;
		public virtual global::java.lang.String getUrl() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.location.Address._getUrl6810)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._getUrl6810)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setUrl6811;
		public virtual void setUrl(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Address._setUrl6811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._setUrl6811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setExtras6812;
		public virtual void setExtras(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Address._setExtras6812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._setExtras6812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Address6813;
		public Address(java.util.Locale arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.location.Address.staticClass, global::android.location.Address._Address6813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR6814;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.location.Address.staticClass, _CREATOR6814)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.location.Address.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/location/Address"));
			global::android.location.Address._toString6770 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "toString", "()Ljava/lang/String;");
			global::android.location.Address._getLocality6771 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "getLocality", "()Ljava/lang/String;");
			global::android.location.Address._writeToParcel6772 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.location.Address._describeContents6773 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "describeContents", "()I");
			global::android.location.Address._getExtras6774 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "getExtras", "()Landroid/os/Bundle;");
			global::android.location.Address._getLocale6775 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "getLocale", "()Ljava/util/Locale;");
			global::android.location.Address._getMaxAddressLineIndex6776 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "getMaxAddressLineIndex", "()I");
			global::android.location.Address._getAddressLine6777 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "getAddressLine", "(I)Ljava/lang/String;");
			global::android.location.Address._setAddressLine6778 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "setAddressLine", "(ILjava/lang/String;)V");
			global::android.location.Address._getFeatureName6779 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "getFeatureName", "()Ljava/lang/String;");
			global::android.location.Address._setFeatureName6780 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "setFeatureName", "(Ljava/lang/String;)V");
			global::android.location.Address._getAdminArea6781 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "getAdminArea", "()Ljava/lang/String;");
			global::android.location.Address._setAdminArea6782 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "setAdminArea", "(Ljava/lang/String;)V");
			global::android.location.Address._getSubAdminArea6783 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "getSubAdminArea", "()Ljava/lang/String;");
			global::android.location.Address._setSubAdminArea6784 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "setSubAdminArea", "(Ljava/lang/String;)V");
			global::android.location.Address._setLocality6785 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "setLocality", "(Ljava/lang/String;)V");
			global::android.location.Address._getSubLocality6786 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "getSubLocality", "()Ljava/lang/String;");
			global::android.location.Address._setSubLocality6787 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "setSubLocality", "(Ljava/lang/String;)V");
			global::android.location.Address._getThoroughfare6788 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "getThoroughfare", "()Ljava/lang/String;");
			global::android.location.Address._setThoroughfare6789 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "setThoroughfare", "(Ljava/lang/String;)V");
			global::android.location.Address._getSubThoroughfare6790 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "getSubThoroughfare", "()Ljava/lang/String;");
			global::android.location.Address._setSubThoroughfare6791 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "setSubThoroughfare", "(Ljava/lang/String;)V");
			global::android.location.Address._getPremises6792 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "getPremises", "()Ljava/lang/String;");
			global::android.location.Address._setPremises6793 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "setPremises", "(Ljava/lang/String;)V");
			global::android.location.Address._getPostalCode6794 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "getPostalCode", "()Ljava/lang/String;");
			global::android.location.Address._setPostalCode6795 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "setPostalCode", "(Ljava/lang/String;)V");
			global::android.location.Address._getCountryCode6796 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "getCountryCode", "()Ljava/lang/String;");
			global::android.location.Address._setCountryCode6797 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "setCountryCode", "(Ljava/lang/String;)V");
			global::android.location.Address._getCountryName6798 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "getCountryName", "()Ljava/lang/String;");
			global::android.location.Address._setCountryName6799 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "setCountryName", "(Ljava/lang/String;)V");
			global::android.location.Address._hasLatitude6800 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "hasLatitude", "()Z");
			global::android.location.Address._getLatitude6801 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "getLatitude", "()D");
			global::android.location.Address._setLatitude6802 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "setLatitude", "(D)V");
			global::android.location.Address._clearLatitude6803 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "clearLatitude", "()V");
			global::android.location.Address._hasLongitude6804 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "hasLongitude", "()Z");
			global::android.location.Address._getLongitude6805 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "getLongitude", "()D");
			global::android.location.Address._setLongitude6806 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "setLongitude", "(D)V");
			global::android.location.Address._clearLongitude6807 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "clearLongitude", "()V");
			global::android.location.Address._getPhone6808 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "getPhone", "()Ljava/lang/String;");
			global::android.location.Address._setPhone6809 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "setPhone", "(Ljava/lang/String;)V");
			global::android.location.Address._getUrl6810 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "getUrl", "()Ljava/lang/String;");
			global::android.location.Address._setUrl6811 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "setUrl", "(Ljava/lang/String;)V");
			global::android.location.Address._setExtras6812 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "setExtras", "(Landroid/os/Bundle;)V");
			global::android.location.Address._Address6813 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "<init>", "(Ljava/util/Locale;)V");
			global::android.location.Address._CREATOR6814 = @__env.GetStaticFieldIDNoThrow(global::android.location.Address.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
