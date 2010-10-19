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
		internal static global::MonoJavaBridge.MethodId _toString4649;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.location.Address._toString4649)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._toString4649)) as java.lang.String;
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
		internal static global::MonoJavaBridge.MethodId _getLocality4650;
		public virtual global::java.lang.String getLocality() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.location.Address._getLocality4650)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._getLocality4650)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel4651;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Address._writeToParcel4651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._writeToParcel4651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents4652;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.location.Address._describeContents4652);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._describeContents4652);
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
		internal static global::MonoJavaBridge.MethodId _getExtras4653;
		public virtual global::android.os.Bundle getExtras() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.location.Address._getExtras4653)) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._getExtras4653)) as android.os.Bundle;
		}
		public new global::java.util.Locale Locale
		{
			get
			{
				return getLocale();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocale4654;
		public virtual global::java.util.Locale getLocale() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.location.Address._getLocale4654)) as java.util.Locale;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._getLocale4654)) as java.util.Locale;
		}
		public new int MaxAddressLineIndex
		{
			get
			{
				return getMaxAddressLineIndex();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMaxAddressLineIndex4655;
		public virtual int getMaxAddressLineIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.location.Address._getMaxAddressLineIndex4655);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._getMaxAddressLineIndex4655);
		}
		internal static global::MonoJavaBridge.MethodId _getAddressLine4656;
		public virtual global::java.lang.String getAddressLine(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.location.Address._getAddressLine4656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._getAddressLine4656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setAddressLine4657;
		public virtual void setAddressLine(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Address._setAddressLine4657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._setAddressLine4657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		internal static global::MonoJavaBridge.MethodId _getFeatureName4658;
		public virtual global::java.lang.String getFeatureName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.location.Address._getFeatureName4658)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._getFeatureName4658)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setFeatureName4659;
		public virtual void setFeatureName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Address._setFeatureName4659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._setFeatureName4659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getAdminArea4660;
		public virtual global::java.lang.String getAdminArea() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.location.Address._getAdminArea4660)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._getAdminArea4660)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setAdminArea4661;
		public virtual void setAdminArea(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Address._setAdminArea4661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._setAdminArea4661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getSubAdminArea4662;
		public virtual global::java.lang.String getSubAdminArea() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.location.Address._getSubAdminArea4662)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._getSubAdminArea4662)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setSubAdminArea4663;
		public virtual void setSubAdminArea(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Address._setSubAdminArea4663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._setSubAdminArea4663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLocality4664;
		public virtual void setLocality(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Address._setLocality4664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._setLocality4664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getSubLocality4665;
		public virtual global::java.lang.String getSubLocality() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.location.Address._getSubLocality4665)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._getSubLocality4665)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setSubLocality4666;
		public virtual void setSubLocality(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Address._setSubLocality4666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._setSubLocality4666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getThoroughfare4667;
		public virtual global::java.lang.String getThoroughfare() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.location.Address._getThoroughfare4667)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._getThoroughfare4667)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setThoroughfare4668;
		public virtual void setThoroughfare(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Address._setThoroughfare4668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._setThoroughfare4668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getSubThoroughfare4669;
		public virtual global::java.lang.String getSubThoroughfare() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.location.Address._getSubThoroughfare4669)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._getSubThoroughfare4669)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setSubThoroughfare4670;
		public virtual void setSubThoroughfare(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Address._setSubThoroughfare4670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._setSubThoroughfare4670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getPremises4671;
		public virtual global::java.lang.String getPremises() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.location.Address._getPremises4671)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._getPremises4671)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setPremises4672;
		public virtual void setPremises(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Address._setPremises4672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._setPremises4672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getPostalCode4673;
		public virtual global::java.lang.String getPostalCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.location.Address._getPostalCode4673)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._getPostalCode4673)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setPostalCode4674;
		public virtual void setPostalCode(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Address._setPostalCode4674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._setPostalCode4674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getCountryCode4675;
		public virtual global::java.lang.String getCountryCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.location.Address._getCountryCode4675)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._getCountryCode4675)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setCountryCode4676;
		public virtual void setCountryCode(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Address._setCountryCode4676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._setCountryCode4676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getCountryName4677;
		public virtual global::java.lang.String getCountryName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.location.Address._getCountryName4677)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._getCountryName4677)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setCountryName4678;
		public virtual void setCountryName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Address._setCountryName4678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._setCountryName4678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasLatitude4679;
		public virtual bool hasLatitude() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.Address._hasLatitude4679);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._hasLatitude4679);
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
		internal static global::MonoJavaBridge.MethodId _getLatitude4680;
		public virtual double getLatitude() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::android.location.Address._getLatitude4680);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._getLatitude4680);
		}
		internal static global::MonoJavaBridge.MethodId _setLatitude4681;
		public virtual void setLatitude(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Address._setLatitude4681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._setLatitude4681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearLatitude4682;
		public virtual void clearLatitude() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Address._clearLatitude4682);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._clearLatitude4682);
		}
		internal static global::MonoJavaBridge.MethodId _hasLongitude4683;
		public virtual bool hasLongitude() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.Address._hasLongitude4683);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._hasLongitude4683);
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
		internal static global::MonoJavaBridge.MethodId _getLongitude4684;
		public virtual double getLongitude() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::android.location.Address._getLongitude4684);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._getLongitude4684);
		}
		internal static global::MonoJavaBridge.MethodId _setLongitude4685;
		public virtual void setLongitude(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Address._setLongitude4685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._setLongitude4685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearLongitude4686;
		public virtual void clearLongitude() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Address._clearLongitude4686);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._clearLongitude4686);
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
		internal static global::MonoJavaBridge.MethodId _getPhone4687;
		public virtual global::java.lang.String getPhone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.location.Address._getPhone4687)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._getPhone4687)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setPhone4688;
		public virtual void setPhone(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Address._setPhone4688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._setPhone4688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getUrl4689;
		public virtual global::java.lang.String getUrl() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.location.Address._getUrl4689)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._getUrl4689)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setUrl4690;
		public virtual void setUrl(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Address._setUrl4690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._setUrl4690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setExtras4691;
		public virtual void setExtras(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Address._setExtras4691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Address.staticClass, global::android.location.Address._setExtras4691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Address4692;
		public Address(java.util.Locale arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.location.Address.staticClass, global::android.location.Address._Address4692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR4693;
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
			global::android.location.Address.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/location/Address"));
			global::android.location.Address._toString4649 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "toString", "()Ljava/lang/String;");
			global::android.location.Address._getLocality4650 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "getLocality", "()Ljava/lang/String;");
			global::android.location.Address._writeToParcel4651 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.location.Address._describeContents4652 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "describeContents", "()I");
			global::android.location.Address._getExtras4653 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "getExtras", "()Landroid/os/Bundle;");
			global::android.location.Address._getLocale4654 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "getLocale", "()Ljava/util/Locale;");
			global::android.location.Address._getMaxAddressLineIndex4655 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "getMaxAddressLineIndex", "()I");
			global::android.location.Address._getAddressLine4656 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "getAddressLine", "(I)Ljava/lang/String;");
			global::android.location.Address._setAddressLine4657 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "setAddressLine", "(ILjava/lang/String;)V");
			global::android.location.Address._getFeatureName4658 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "getFeatureName", "()Ljava/lang/String;");
			global::android.location.Address._setFeatureName4659 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "setFeatureName", "(Ljava/lang/String;)V");
			global::android.location.Address._getAdminArea4660 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "getAdminArea", "()Ljava/lang/String;");
			global::android.location.Address._setAdminArea4661 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "setAdminArea", "(Ljava/lang/String;)V");
			global::android.location.Address._getSubAdminArea4662 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "getSubAdminArea", "()Ljava/lang/String;");
			global::android.location.Address._setSubAdminArea4663 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "setSubAdminArea", "(Ljava/lang/String;)V");
			global::android.location.Address._setLocality4664 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "setLocality", "(Ljava/lang/String;)V");
			global::android.location.Address._getSubLocality4665 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "getSubLocality", "()Ljava/lang/String;");
			global::android.location.Address._setSubLocality4666 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "setSubLocality", "(Ljava/lang/String;)V");
			global::android.location.Address._getThoroughfare4667 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "getThoroughfare", "()Ljava/lang/String;");
			global::android.location.Address._setThoroughfare4668 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "setThoroughfare", "(Ljava/lang/String;)V");
			global::android.location.Address._getSubThoroughfare4669 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "getSubThoroughfare", "()Ljava/lang/String;");
			global::android.location.Address._setSubThoroughfare4670 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "setSubThoroughfare", "(Ljava/lang/String;)V");
			global::android.location.Address._getPremises4671 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "getPremises", "()Ljava/lang/String;");
			global::android.location.Address._setPremises4672 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "setPremises", "(Ljava/lang/String;)V");
			global::android.location.Address._getPostalCode4673 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "getPostalCode", "()Ljava/lang/String;");
			global::android.location.Address._setPostalCode4674 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "setPostalCode", "(Ljava/lang/String;)V");
			global::android.location.Address._getCountryCode4675 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "getCountryCode", "()Ljava/lang/String;");
			global::android.location.Address._setCountryCode4676 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "setCountryCode", "(Ljava/lang/String;)V");
			global::android.location.Address._getCountryName4677 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "getCountryName", "()Ljava/lang/String;");
			global::android.location.Address._setCountryName4678 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "setCountryName", "(Ljava/lang/String;)V");
			global::android.location.Address._hasLatitude4679 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "hasLatitude", "()Z");
			global::android.location.Address._getLatitude4680 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "getLatitude", "()D");
			global::android.location.Address._setLatitude4681 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "setLatitude", "(D)V");
			global::android.location.Address._clearLatitude4682 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "clearLatitude", "()V");
			global::android.location.Address._hasLongitude4683 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "hasLongitude", "()Z");
			global::android.location.Address._getLongitude4684 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "getLongitude", "()D");
			global::android.location.Address._setLongitude4685 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "setLongitude", "(D)V");
			global::android.location.Address._clearLongitude4686 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "clearLongitude", "()V");
			global::android.location.Address._getPhone4687 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "getPhone", "()Ljava/lang/String;");
			global::android.location.Address._setPhone4688 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "setPhone", "(Ljava/lang/String;)V");
			global::android.location.Address._getUrl4689 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "getUrl", "()Ljava/lang/String;");
			global::android.location.Address._setUrl4690 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "setUrl", "(Ljava/lang/String;)V");
			global::android.location.Address._setExtras4691 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "setExtras", "(Landroid/os/Bundle;)V");
			global::android.location.Address._Address4692 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "<init>", "(Ljava/util/Locale;)V");
		}
	}
}
