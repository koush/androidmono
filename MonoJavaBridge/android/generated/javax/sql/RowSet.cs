namespace javax.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.sql.RowSet_))]
	public partial interface RowSet : java.sql.ResultSet
	{
		void setReadOnly(bool arg0);
		void setBoolean(java.lang.String arg0, bool arg1);
		void setBoolean(int arg0, bool arg1);
		void setByte(java.lang.String arg0, byte arg1);
		void setByte(int arg0, byte arg1);
		void setShort(int arg0, short arg1);
		void setShort(java.lang.String arg0, short arg1);
		void setInt(java.lang.String arg0, int arg1);
		void setInt(int arg0, int arg1);
		void setLong(int arg0, long arg1);
		void setLong(java.lang.String arg0, long arg1);
		void setFloat(java.lang.String arg0, float arg1);
		void setFloat(int arg0, float arg1);
		void setDouble(int arg0, double arg1);
		void setDouble(java.lang.String arg0, double arg1);
		bool isReadOnly();
		void setTimestamp(int arg0, java.sql.Timestamp arg1, java.util.Calendar arg2);
		void setTimestamp(java.lang.String arg0, java.sql.Timestamp arg1, java.util.Calendar arg2);
		void setTimestamp(int arg0, java.sql.Timestamp arg1);
		void setTimestamp(java.lang.String arg0, java.sql.Timestamp arg1);
		void setURL(int arg0, java.net.URL arg1);
		void setTime(java.lang.String arg0, java.sql.Time arg1, java.util.Calendar arg2);
		void setTime(java.lang.String arg0, java.sql.Time arg1);
		void setTime(int arg0, java.sql.Time arg1, java.util.Calendar arg2);
		void setTime(int arg0, java.sql.Time arg1);
		void setDate(int arg0, java.sql.Date arg1, java.util.Calendar arg2);
		void setDate(int arg0, java.sql.Date arg1);
		void setDate(java.lang.String arg0, java.sql.Date arg1, java.util.Calendar arg2);
		void setDate(java.lang.String arg0, java.sql.Date arg1);
		void execute();
		void setPassword(java.lang.String arg0);
		void setType(int arg0);
		global::java.lang.String getPassword();
		void setString(int arg0, java.lang.String arg1);
		void setString(java.lang.String arg0, java.lang.String arg1);
		void setObject(java.lang.String arg0, java.lang.Object arg1, int arg2, int arg3);
		void setObject(int arg0, java.lang.Object arg1, int arg2, int arg3);
		void setObject(int arg0, java.lang.Object arg1, int arg2);
		void setObject(java.lang.String arg0, java.lang.Object arg1, int arg2);
		void setObject(java.lang.String arg0, java.lang.Object arg1);
		void setObject(int arg0, java.lang.Object arg1);
		global::java.lang.String getUrl();
		void setUrl(java.lang.String arg0);
		void setBytes(java.lang.String arg0, byte[] arg1);
		void setBytes(int arg0, byte[] arg1);
		void setBinaryStream(java.lang.String arg0, java.io.InputStream arg1, int arg2);
		void setBinaryStream(int arg0, java.io.InputStream arg1, int arg2);
		void setBinaryStream(java.lang.String arg0, java.io.InputStream arg1);
		void setBinaryStream(int arg0, java.io.InputStream arg1);
		void setNull(java.lang.String arg0, int arg1, java.lang.String arg2);
		void setNull(int arg0, int arg1, java.lang.String arg2);
		void setNull(int arg0, int arg1);
		void setNull(java.lang.String arg0, int arg1);
		void setBigDecimal(java.lang.String arg0, java.math.BigDecimal arg1);
		void setBigDecimal(int arg0, java.math.BigDecimal arg1);
		void setAsciiStream(int arg0, java.io.InputStream arg1, int arg2);
		void setAsciiStream(java.lang.String arg0, java.io.InputStream arg1, int arg2);
		void setAsciiStream(int arg0, java.io.InputStream arg1);
		void setAsciiStream(java.lang.String arg0, java.io.InputStream arg1);
		void setCharacterStream(java.lang.String arg0, java.io.Reader arg1, int arg2);
		void setCharacterStream(java.lang.String arg0, java.io.Reader arg1);
		void setCharacterStream(int arg0, java.io.Reader arg1);
		void setCharacterStream(int arg0, java.io.Reader arg1, int arg2);
		void setNString(java.lang.String arg0, java.lang.String arg1);
		void setNString(int arg0, java.lang.String arg1);
		void setNCharacterStream(int arg0, java.io.Reader arg1, long arg2);
		void setNCharacterStream(int arg0, java.io.Reader arg1);
		void setNCharacterStream(java.lang.String arg0, java.io.Reader arg1, long arg2);
		void setNCharacterStream(java.lang.String arg0, java.io.Reader arg1);
		void setNClob(java.lang.String arg0, java.io.Reader arg1);
		void setNClob(int arg0, java.io.Reader arg1);
		void setNClob(java.lang.String arg0, java.io.Reader arg1, long arg2);
		void setNClob(int arg0, java.io.Reader arg1, long arg2);
		void setClob(java.lang.String arg0, java.io.Reader arg1, long arg2);
		void setClob(java.lang.String arg0, java.sql.Clob arg1);
		void setClob(java.lang.String arg0, java.io.Reader arg1);
		void setClob(int arg0, java.sql.Clob arg1);
		void setClob(int arg0, java.io.Reader arg1, long arg2);
		void setClob(int arg0, java.io.Reader arg1);
		void setBlob(int arg0, java.io.InputStream arg1);
		void setBlob(java.lang.String arg0, java.sql.Blob arg1);
		void setBlob(java.lang.String arg0, java.io.InputStream arg1);
		void setBlob(int arg0, java.sql.Blob arg1);
		void setBlob(int arg0, java.io.InputStream arg1, long arg2);
		void setBlob(java.lang.String arg0, java.io.InputStream arg1, long arg2);
		void clearParameters();
		void setRef(int arg0, java.sql.Ref arg1);
		void setArray(int arg0, java.sql.Array arg1);
		int getMaxFieldSize();
		void setMaxFieldSize(int arg0);
		int getMaxRows();
		void setMaxRows(int arg0);
		void setEscapeProcessing(bool arg0);
		int getQueryTimeout();
		void setQueryTimeout(int arg0);
		void setTransactionIsolation(int arg0);
		int getTransactionIsolation();
		global::java.util.Map getTypeMap();
		void setTypeMap(java.util.Map arg0);
		global::java.lang.String getDataSourceName();
		void setDataSourceName(java.lang.String arg0);
		global::java.lang.String getUsername();
		void setUsername(java.lang.String arg0);
		global::java.lang.String getCommand();
		void setCommand(java.lang.String arg0);
		bool getEscapeProcessing();
		void setConcurrency(int arg0);
		void addRowSetListener(javax.sql.RowSetListener arg0);
		void removeRowSetListener(javax.sql.RowSetListener arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.sql.RowSet))]
	internal sealed partial class RowSet_ : java.lang.Object, RowSet
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal RowSet_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setReadOnly30290;
		void javax.sql.RowSet.setReadOnly(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setReadOnly30290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setReadOnly30290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setBoolean30291;
		void javax.sql.RowSet.setBoolean(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setBoolean30291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setBoolean30291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBoolean30292;
		void javax.sql.RowSet.setBoolean(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setBoolean30292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setBoolean30292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setByte30293;
		void javax.sql.RowSet.setByte(java.lang.String arg0, byte arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setByte30293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setByte30293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setByte30294;
		void javax.sql.RowSet.setByte(int arg0, byte arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setByte30294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setByte30294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setShort30295;
		void javax.sql.RowSet.setShort(int arg0, short arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setShort30295, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setShort30295, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setShort30296;
		void javax.sql.RowSet.setShort(java.lang.String arg0, short arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setShort30296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setShort30296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setInt30297;
		void javax.sql.RowSet.setInt(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setInt30297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setInt30297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setInt30298;
		void javax.sql.RowSet.setInt(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setInt30298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setInt30298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setLong30299;
		void javax.sql.RowSet.setLong(int arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setLong30299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setLong30299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setLong30300;
		void javax.sql.RowSet.setLong(java.lang.String arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setLong30300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setLong30300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFloat30301;
		void javax.sql.RowSet.setFloat(java.lang.String arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setFloat30301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setFloat30301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFloat30302;
		void javax.sql.RowSet.setFloat(int arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setFloat30302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setFloat30302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDouble30303;
		void javax.sql.RowSet.setDouble(int arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setDouble30303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setDouble30303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDouble30304;
		void javax.sql.RowSet.setDouble(java.lang.String arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setDouble30304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setDouble30304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly30305;
		bool javax.sql.RowSet.isReadOnly()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_._isReadOnly30305);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._isReadOnly30305);
		}
		internal static global::MonoJavaBridge.MethodId _setTimestamp30306;
		void javax.sql.RowSet.setTimestamp(int arg0, java.sql.Timestamp arg1, java.util.Calendar arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setTimestamp30306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setTimestamp30306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setTimestamp30307;
		void javax.sql.RowSet.setTimestamp(java.lang.String arg0, java.sql.Timestamp arg1, java.util.Calendar arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setTimestamp30307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setTimestamp30307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setTimestamp30308;
		void javax.sql.RowSet.setTimestamp(int arg0, java.sql.Timestamp arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setTimestamp30308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setTimestamp30308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTimestamp30309;
		void javax.sql.RowSet.setTimestamp(java.lang.String arg0, java.sql.Timestamp arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setTimestamp30309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setTimestamp30309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setURL30310;
		void javax.sql.RowSet.setURL(int arg0, java.net.URL arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setURL30310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setURL30310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTime30311;
		void javax.sql.RowSet.setTime(java.lang.String arg0, java.sql.Time arg1, java.util.Calendar arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setTime30311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setTime30311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setTime30312;
		void javax.sql.RowSet.setTime(java.lang.String arg0, java.sql.Time arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setTime30312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setTime30312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTime30313;
		void javax.sql.RowSet.setTime(int arg0, java.sql.Time arg1, java.util.Calendar arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setTime30313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setTime30313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setTime30314;
		void javax.sql.RowSet.setTime(int arg0, java.sql.Time arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setTime30314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setTime30314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDate30315;
		void javax.sql.RowSet.setDate(int arg0, java.sql.Date arg1, java.util.Calendar arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setDate30315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setDate30315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setDate30316;
		void javax.sql.RowSet.setDate(int arg0, java.sql.Date arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setDate30316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setDate30316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDate30317;
		void javax.sql.RowSet.setDate(java.lang.String arg0, java.sql.Date arg1, java.util.Calendar arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setDate30317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setDate30317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setDate30318;
		void javax.sql.RowSet.setDate(java.lang.String arg0, java.sql.Date arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setDate30318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setDate30318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _execute30319;
		void javax.sql.RowSet.execute()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._execute30319);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._execute30319);
		}
		internal static global::MonoJavaBridge.MethodId _setPassword30320;
		void javax.sql.RowSet.setPassword(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setPassword30320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setPassword30320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setType30321;
		void javax.sql.RowSet.setType(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setType30321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setType30321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPassword30322;
		global::java.lang.String javax.sql.RowSet.getPassword()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getPassword30322)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getPassword30322)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setString30323;
		void javax.sql.RowSet.setString(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setString30323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setString30323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setString30324;
		void javax.sql.RowSet.setString(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setString30324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setString30324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setObject30325;
		void javax.sql.RowSet.setObject(java.lang.String arg0, java.lang.Object arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setObject30325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setObject30325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setObject30326;
		void javax.sql.RowSet.setObject(int arg0, java.lang.Object arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setObject30326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setObject30326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setObject30327;
		void javax.sql.RowSet.setObject(int arg0, java.lang.Object arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setObject30327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setObject30327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setObject30328;
		void javax.sql.RowSet.setObject(java.lang.String arg0, java.lang.Object arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setObject30328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setObject30328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setObject30329;
		void javax.sql.RowSet.setObject(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setObject30329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setObject30329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setObject30330;
		void javax.sql.RowSet.setObject(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setObject30330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setObject30330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getUrl30331;
		global::java.lang.String javax.sql.RowSet.getUrl()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getUrl30331)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getUrl30331)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setUrl30332;
		void javax.sql.RowSet.setUrl(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setUrl30332, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setUrl30332, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setBytes30333;
		void javax.sql.RowSet.setBytes(java.lang.String arg0, byte[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setBytes30333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setBytes30333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBytes30334;
		void javax.sql.RowSet.setBytes(int arg0, byte[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setBytes30334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setBytes30334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBinaryStream30335;
		void javax.sql.RowSet.setBinaryStream(java.lang.String arg0, java.io.InputStream arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setBinaryStream30335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setBinaryStream30335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setBinaryStream30336;
		void javax.sql.RowSet.setBinaryStream(int arg0, java.io.InputStream arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setBinaryStream30336, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setBinaryStream30336, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setBinaryStream30337;
		void javax.sql.RowSet.setBinaryStream(java.lang.String arg0, java.io.InputStream arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setBinaryStream30337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setBinaryStream30337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBinaryStream30338;
		void javax.sql.RowSet.setBinaryStream(int arg0, java.io.InputStream arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setBinaryStream30338, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setBinaryStream30338, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNull30339;
		void javax.sql.RowSet.setNull(java.lang.String arg0, int arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setNull30339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setNull30339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setNull30340;
		void javax.sql.RowSet.setNull(int arg0, int arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setNull30340, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setNull30340, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setNull30341;
		void javax.sql.RowSet.setNull(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setNull30341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setNull30341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNull30342;
		void javax.sql.RowSet.setNull(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setNull30342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setNull30342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBigDecimal30343;
		void javax.sql.RowSet.setBigDecimal(java.lang.String arg0, java.math.BigDecimal arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setBigDecimal30343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setBigDecimal30343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBigDecimal30344;
		void javax.sql.RowSet.setBigDecimal(int arg0, java.math.BigDecimal arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setBigDecimal30344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setBigDecimal30344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setAsciiStream30345;
		void javax.sql.RowSet.setAsciiStream(int arg0, java.io.InputStream arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setAsciiStream30345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setAsciiStream30345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setAsciiStream30346;
		void javax.sql.RowSet.setAsciiStream(java.lang.String arg0, java.io.InputStream arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setAsciiStream30346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setAsciiStream30346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setAsciiStream30347;
		void javax.sql.RowSet.setAsciiStream(int arg0, java.io.InputStream arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setAsciiStream30347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setAsciiStream30347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setAsciiStream30348;
		void javax.sql.RowSet.setAsciiStream(java.lang.String arg0, java.io.InputStream arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setAsciiStream30348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setAsciiStream30348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setCharacterStream30349;
		void javax.sql.RowSet.setCharacterStream(java.lang.String arg0, java.io.Reader arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setCharacterStream30349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setCharacterStream30349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setCharacterStream30350;
		void javax.sql.RowSet.setCharacterStream(java.lang.String arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setCharacterStream30350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setCharacterStream30350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setCharacterStream30351;
		void javax.sql.RowSet.setCharacterStream(int arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setCharacterStream30351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setCharacterStream30351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setCharacterStream30352;
		void javax.sql.RowSet.setCharacterStream(int arg0, java.io.Reader arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setCharacterStream30352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setCharacterStream30352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setNString30353;
		void javax.sql.RowSet.setNString(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setNString30353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setNString30353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNString30354;
		void javax.sql.RowSet.setNString(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setNString30354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setNString30354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNCharacterStream30355;
		void javax.sql.RowSet.setNCharacterStream(int arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setNCharacterStream30355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setNCharacterStream30355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setNCharacterStream30356;
		void javax.sql.RowSet.setNCharacterStream(int arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setNCharacterStream30356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setNCharacterStream30356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNCharacterStream30357;
		void javax.sql.RowSet.setNCharacterStream(java.lang.String arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setNCharacterStream30357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setNCharacterStream30357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setNCharacterStream30358;
		void javax.sql.RowSet.setNCharacterStream(java.lang.String arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setNCharacterStream30358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setNCharacterStream30358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNClob30359;
		void javax.sql.RowSet.setNClob(java.lang.String arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setNClob30359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setNClob30359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNClob30360;
		void javax.sql.RowSet.setNClob(int arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setNClob30360, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setNClob30360, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNClob30361;
		void javax.sql.RowSet.setNClob(java.lang.String arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setNClob30361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setNClob30361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setNClob30362;
		void javax.sql.RowSet.setNClob(int arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setNClob30362, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setNClob30362, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setClob30363;
		void javax.sql.RowSet.setClob(java.lang.String arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setClob30363, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setClob30363, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setClob30364;
		void javax.sql.RowSet.setClob(java.lang.String arg0, java.sql.Clob arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setClob30364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setClob30364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setClob30365;
		void javax.sql.RowSet.setClob(java.lang.String arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setClob30365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setClob30365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setClob30366;
		void javax.sql.RowSet.setClob(int arg0, java.sql.Clob arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setClob30366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setClob30366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setClob30367;
		void javax.sql.RowSet.setClob(int arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setClob30367, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setClob30367, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setClob30368;
		void javax.sql.RowSet.setClob(int arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setClob30368, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setClob30368, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBlob30369;
		void javax.sql.RowSet.setBlob(int arg0, java.io.InputStream arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setBlob30369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setBlob30369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBlob30370;
		void javax.sql.RowSet.setBlob(java.lang.String arg0, java.sql.Blob arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setBlob30370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setBlob30370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBlob30371;
		void javax.sql.RowSet.setBlob(java.lang.String arg0, java.io.InputStream arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setBlob30371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setBlob30371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBlob30372;
		void javax.sql.RowSet.setBlob(int arg0, java.sql.Blob arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setBlob30372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setBlob30372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBlob30373;
		void javax.sql.RowSet.setBlob(int arg0, java.io.InputStream arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setBlob30373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setBlob30373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setBlob30374;
		void javax.sql.RowSet.setBlob(java.lang.String arg0, java.io.InputStream arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setBlob30374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setBlob30374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _clearParameters30375;
		void javax.sql.RowSet.clearParameters()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._clearParameters30375);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._clearParameters30375);
		}
		internal static global::MonoJavaBridge.MethodId _setRef30376;
		void javax.sql.RowSet.setRef(int arg0, java.sql.Ref arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setRef30376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setRef30376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setArray30377;
		void javax.sql.RowSet.setArray(int arg0, java.sql.Array arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setArray30377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setArray30377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getMaxFieldSize30378;
		int javax.sql.RowSet.getMaxFieldSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.sql.RowSet_._getMaxFieldSize30378);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getMaxFieldSize30378);
		}
		internal static global::MonoJavaBridge.MethodId _setMaxFieldSize30379;
		void javax.sql.RowSet.setMaxFieldSize(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setMaxFieldSize30379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setMaxFieldSize30379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMaxRows30380;
		int javax.sql.RowSet.getMaxRows()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.sql.RowSet_._getMaxRows30380);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getMaxRows30380);
		}
		internal static global::MonoJavaBridge.MethodId _setMaxRows30381;
		void javax.sql.RowSet.setMaxRows(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setMaxRows30381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setMaxRows30381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEscapeProcessing30382;
		void javax.sql.RowSet.setEscapeProcessing(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setEscapeProcessing30382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setEscapeProcessing30382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getQueryTimeout30383;
		int javax.sql.RowSet.getQueryTimeout()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.sql.RowSet_._getQueryTimeout30383);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getQueryTimeout30383);
		}
		internal static global::MonoJavaBridge.MethodId _setQueryTimeout30384;
		void javax.sql.RowSet.setQueryTimeout(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setQueryTimeout30384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setQueryTimeout30384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTransactionIsolation30385;
		void javax.sql.RowSet.setTransactionIsolation(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setTransactionIsolation30385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setTransactionIsolation30385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTransactionIsolation30386;
		int javax.sql.RowSet.getTransactionIsolation()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.sql.RowSet_._getTransactionIsolation30386);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getTransactionIsolation30386);
		}
		internal static global::MonoJavaBridge.MethodId _getTypeMap30387;
		global::java.util.Map javax.sql.RowSet.getTypeMap()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getTypeMap30387)) as java.util.Map;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getTypeMap30387)) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _setTypeMap30388;
		void javax.sql.RowSet.setTypeMap(java.util.Map arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setTypeMap30388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setTypeMap30388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDataSourceName30389;
		global::java.lang.String javax.sql.RowSet.getDataSourceName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getDataSourceName30389)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getDataSourceName30389)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setDataSourceName30390;
		void javax.sql.RowSet.setDataSourceName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setDataSourceName30390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setDataSourceName30390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getUsername30391;
		global::java.lang.String javax.sql.RowSet.getUsername()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getUsername30391)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getUsername30391)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setUsername30392;
		void javax.sql.RowSet.setUsername(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setUsername30392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setUsername30392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCommand30393;
		global::java.lang.String javax.sql.RowSet.getCommand()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getCommand30393)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getCommand30393)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setCommand30394;
		void javax.sql.RowSet.setCommand(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setCommand30394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setCommand30394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getEscapeProcessing30395;
		bool javax.sql.RowSet.getEscapeProcessing()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_._getEscapeProcessing30395);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getEscapeProcessing30395);
		}
		internal static global::MonoJavaBridge.MethodId _setConcurrency30396;
		void javax.sql.RowSet.setConcurrency(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setConcurrency30396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setConcurrency30396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addRowSetListener30397;
		void javax.sql.RowSet.addRowSetListener(javax.sql.RowSetListener arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._addRowSetListener30397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._addRowSetListener30397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeRowSetListener30398;
		void javax.sql.RowSet.removeRowSetListener(javax.sql.RowSetListener arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._removeRowSetListener30398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._removeRowSetListener30398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getObject30399;
		global::java.lang.Object java.sql.ResultSet.getObject(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getObject30399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getObject30399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getObject30400;
		global::java.lang.Object java.sql.ResultSet.getObject(int arg0, java.util.Map arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getObject30400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getObject30400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getObject30401;
		global::java.lang.Object java.sql.ResultSet.getObject(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getObject30401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getObject30401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getObject30402;
		global::java.lang.Object java.sql.ResultSet.getObject(java.lang.String arg0, java.util.Map arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getObject30402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getObject30402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getBoolean30403;
		bool java.sql.ResultSet.getBoolean(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_._getBoolean30403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getBoolean30403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBoolean30404;
		bool java.sql.ResultSet.getBoolean(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_._getBoolean30404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getBoolean30404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getByte30405;
		byte java.sql.ResultSet.getByte(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::javax.sql.RowSet_._getByte30405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getByte30405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getByte30406;
		byte java.sql.ResultSet.getByte(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::javax.sql.RowSet_._getByte30406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getByte30406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getShort30407;
		short java.sql.ResultSet.getShort(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::javax.sql.RowSet_._getShort30407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getShort30407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getShort30408;
		short java.sql.ResultSet.getShort(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::javax.sql.RowSet_._getShort30408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getShort30408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInt30409;
		int java.sql.ResultSet.getInt(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.sql.RowSet_._getInt30409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getInt30409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInt30410;
		int java.sql.ResultSet.getInt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.sql.RowSet_._getInt30410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getInt30410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong30411;
		long java.sql.ResultSet.getLong(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::javax.sql.RowSet_._getLong30411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getLong30411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong30412;
		long java.sql.ResultSet.getLong(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::javax.sql.RowSet_._getLong30412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getLong30412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat30413;
		float java.sql.ResultSet.getFloat(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::javax.sql.RowSet_._getFloat30413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getFloat30413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat30414;
		float java.sql.ResultSet.getFloat(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::javax.sql.RowSet_._getFloat30414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getFloat30414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble30415;
		double java.sql.ResultSet.getDouble(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::javax.sql.RowSet_._getDouble30415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getDouble30415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble30416;
		double java.sql.ResultSet.getDouble(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::javax.sql.RowSet_._getDouble30416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getDouble30416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBytes30417;
		byte[] java.sql.ResultSet.getBytes(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getBytes30417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getBytes30417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getBytes30418;
		byte[] java.sql.ResultSet.getBytes(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getBytes30418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getBytes30418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getArray30419;
		global::java.sql.Array java.sql.ResultSet.getArray(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Array>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getArray30419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Array;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Array>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getArray30419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Array;
		}
		internal static global::MonoJavaBridge.MethodId _getArray30420;
		global::java.sql.Array java.sql.ResultSet.getArray(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Array>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getArray30420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Array;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Array>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getArray30420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Array;
		}
		internal static global::MonoJavaBridge.MethodId _next30421;
		bool java.sql.ResultSet.next()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_._next30421);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._next30421);
		}
		internal static global::MonoJavaBridge.MethodId _getURL30422;
		global::java.net.URL java.sql.ResultSet.getURL(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URL>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getURL30422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URL>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getURL30422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _getURL30423;
		global::java.net.URL java.sql.ResultSet.getURL(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URL>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getURL30423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URL>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getURL30423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _close30424;
		void java.sql.ResultSet.close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._close30424);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._close30424);
		}
		internal static global::MonoJavaBridge.MethodId _getType30425;
		int java.sql.ResultSet.getType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.sql.RowSet_._getType30425);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getType30425);
		}
		internal static global::MonoJavaBridge.MethodId _previous30426;
		bool java.sql.ResultSet.previous()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_._previous30426);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._previous30426);
		}
		internal static global::MonoJavaBridge.MethodId _getRef30427;
		global::java.sql.Ref java.sql.ResultSet.getRef(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Ref>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getRef30427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Ref;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Ref>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getRef30427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Ref;
		}
		internal static global::MonoJavaBridge.MethodId _getRef30428;
		global::java.sql.Ref java.sql.ResultSet.getRef(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Ref>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getRef30428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Ref;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Ref>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getRef30428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Ref;
		}
		internal static global::MonoJavaBridge.MethodId _getString30429;
		global::java.lang.String java.sql.ResultSet.getString(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getString30429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getString30429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getString30430;
		global::java.lang.String java.sql.ResultSet.getString(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getString30430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getString30430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isFirst30431;
		bool java.sql.ResultSet.isFirst()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_._isFirst30431);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._isFirst30431);
		}
		internal static global::MonoJavaBridge.MethodId _getTime30432;
		global::java.sql.Time java.sql.ResultSet.getTime(java.lang.String arg0, java.util.Calendar arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getTime30432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Time;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getTime30432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Time;
		}
		internal static global::MonoJavaBridge.MethodId _getTime30433;
		global::java.sql.Time java.sql.ResultSet.getTime(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getTime30433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Time;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getTime30433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Time;
		}
		internal static global::MonoJavaBridge.MethodId _getTime30434;
		global::java.sql.Time java.sql.ResultSet.getTime(int arg0, java.util.Calendar arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getTime30434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Time;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getTime30434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Time;
		}
		internal static global::MonoJavaBridge.MethodId _getTime30435;
		global::java.sql.Time java.sql.ResultSet.getTime(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getTime30435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Time;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getTime30435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Time;
		}
		internal static global::MonoJavaBridge.MethodId _getDate30436;
		global::java.sql.Date java.sql.ResultSet.getDate(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getDate30436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getDate30436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getDate30437;
		global::java.sql.Date java.sql.ResultSet.getDate(java.lang.String arg0, java.util.Calendar arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getDate30437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getDate30437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getDate30438;
		global::java.sql.Date java.sql.ResultSet.getDate(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getDate30438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getDate30438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getDate30439;
		global::java.sql.Date java.sql.ResultSet.getDate(int arg0, java.util.Calendar arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getDate30439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getDate30439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Date;
		}
		internal static global::MonoJavaBridge.MethodId _isClosed30440;
		bool java.sql.ResultSet.isClosed()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_._isClosed30440);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._isClosed30440);
		}
		internal static global::MonoJavaBridge.MethodId _getTimestamp30441;
		global::java.sql.Timestamp java.sql.ResultSet.getTimestamp(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getTimestamp30441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Timestamp;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getTimestamp30441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Timestamp;
		}
		internal static global::MonoJavaBridge.MethodId _getTimestamp30442;
		global::java.sql.Timestamp java.sql.ResultSet.getTimestamp(int arg0, java.util.Calendar arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getTimestamp30442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Timestamp;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getTimestamp30442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Timestamp;
		}
		internal static global::MonoJavaBridge.MethodId _getTimestamp30443;
		global::java.sql.Timestamp java.sql.ResultSet.getTimestamp(java.lang.String arg0, java.util.Calendar arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getTimestamp30443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Timestamp;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getTimestamp30443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Timestamp;
		}
		internal static global::MonoJavaBridge.MethodId _getTimestamp30444;
		global::java.sql.Timestamp java.sql.ResultSet.getTimestamp(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getTimestamp30444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Timestamp;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getTimestamp30444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Timestamp;
		}
		internal static global::MonoJavaBridge.MethodId _last30445;
		bool java.sql.ResultSet.last()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_._last30445);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._last30445);
		}
		internal static global::MonoJavaBridge.MethodId _first30446;
		bool java.sql.ResultSet.first()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_._first30446);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._first30446);
		}
		internal static global::MonoJavaBridge.MethodId _updateBytes30447;
		void java.sql.ResultSet.updateBytes(java.lang.String arg0, byte[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateBytes30447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateBytes30447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateBytes30448;
		void java.sql.ResultSet.updateBytes(int arg0, byte[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateBytes30448, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateBytes30448, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isLast30449;
		bool java.sql.ResultSet.isLast()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_._isLast30449);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._isLast30449);
		}
		internal static global::MonoJavaBridge.MethodId _isBeforeFirst30450;
		bool java.sql.ResultSet.isBeforeFirst()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_._isBeforeFirst30450);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._isBeforeFirst30450);
		}
		internal static global::MonoJavaBridge.MethodId _isAfterLast30451;
		bool java.sql.ResultSet.isAfterLast()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_._isAfterLast30451);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._isAfterLast30451);
		}
		internal static global::MonoJavaBridge.MethodId _getBlob30452;
		global::java.sql.Blob java.sql.ResultSet.getBlob(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Blob>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getBlob30452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Blob;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Blob>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getBlob30452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Blob;
		}
		internal static global::MonoJavaBridge.MethodId _getBlob30453;
		global::java.sql.Blob java.sql.ResultSet.getBlob(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Blob>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getBlob30453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Blob;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Blob>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getBlob30453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Blob;
		}
		internal static global::MonoJavaBridge.MethodId _updateDate30454;
		void java.sql.ResultSet.updateDate(int arg0, java.sql.Date arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateDate30454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateDate30454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateDate30455;
		void java.sql.ResultSet.updateDate(java.lang.String arg0, java.sql.Date arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateDate30455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateDate30455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateTime30456;
		void java.sql.ResultSet.updateTime(int arg0, java.sql.Time arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateTime30456, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateTime30456, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateTime30457;
		void java.sql.ResultSet.updateTime(java.lang.String arg0, java.sql.Time arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateTime30457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateTime30457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _deleteRow30458;
		void java.sql.ResultSet.deleteRow()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._deleteRow30458);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._deleteRow30458);
		}
		internal static global::MonoJavaBridge.MethodId _updateBlob30459;
		void java.sql.ResultSet.updateBlob(java.lang.String arg0, java.sql.Blob arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateBlob30459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateBlob30459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateBlob30460;
		void java.sql.ResultSet.updateBlob(java.lang.String arg0, java.io.InputStream arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateBlob30460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateBlob30460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateBlob30461;
		void java.sql.ResultSet.updateBlob(int arg0, java.io.InputStream arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateBlob30461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateBlob30461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateBlob30462;
		void java.sql.ResultSet.updateBlob(int arg0, java.io.InputStream arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateBlob30462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateBlob30462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateBlob30463;
		void java.sql.ResultSet.updateBlob(java.lang.String arg0, java.io.InputStream arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateBlob30463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateBlob30463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateBlob30464;
		void java.sql.ResultSet.updateBlob(int arg0, java.sql.Blob arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateBlob30464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateBlob30464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateDouble30465;
		void java.sql.ResultSet.updateDouble(int arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateDouble30465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateDouble30465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateDouble30466;
		void java.sql.ResultSet.updateDouble(java.lang.String arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateDouble30466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateDouble30466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateFloat30467;
		void java.sql.ResultSet.updateFloat(java.lang.String arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateFloat30467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateFloat30467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateFloat30468;
		void java.sql.ResultSet.updateFloat(int arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateFloat30468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateFloat30468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateInt30469;
		void java.sql.ResultSet.updateInt(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateInt30469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateInt30469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateInt30470;
		void java.sql.ResultSet.updateInt(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateInt30470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateInt30470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateLong30471;
		void java.sql.ResultSet.updateLong(java.lang.String arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateLong30471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateLong30471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateLong30472;
		void java.sql.ResultSet.updateLong(int arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateLong30472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateLong30472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateShort30473;
		void java.sql.ResultSet.updateShort(int arg0, short arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateShort30473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateShort30473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateShort30474;
		void java.sql.ResultSet.updateShort(java.lang.String arg0, short arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateShort30474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateShort30474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateString30475;
		void java.sql.ResultSet.updateString(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateString30475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateString30475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateString30476;
		void java.sql.ResultSet.updateString(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateString30476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateString30476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _wasNull30477;
		bool java.sql.ResultSet.wasNull()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_._wasNull30477);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._wasNull30477);
		}
		internal static global::MonoJavaBridge.MethodId _getBigDecimal30478;
		global::java.math.BigDecimal java.sql.ResultSet.getBigDecimal(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getBigDecimal30478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getBigDecimal30478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _getBigDecimal30479;
		global::java.math.BigDecimal java.sql.ResultSet.getBigDecimal(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getBigDecimal30479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getBigDecimal30479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _getBigDecimal30480;
		global::java.math.BigDecimal java.sql.ResultSet.getBigDecimal(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getBigDecimal30480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getBigDecimal30480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _getBigDecimal30481;
		global::java.math.BigDecimal java.sql.ResultSet.getBigDecimal(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getBigDecimal30481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getBigDecimal30481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _getAsciiStream30482;
		global::java.io.InputStream java.sql.ResultSet.getAsciiStream(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getAsciiStream30482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getAsciiStream30482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getAsciiStream30483;
		global::java.io.InputStream java.sql.ResultSet.getAsciiStream(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getAsciiStream30483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getAsciiStream30483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getUnicodeStream30484;
		global::java.io.InputStream java.sql.ResultSet.getUnicodeStream(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getUnicodeStream30484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getUnicodeStream30484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getUnicodeStream30485;
		global::java.io.InputStream java.sql.ResultSet.getUnicodeStream(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getUnicodeStream30485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getUnicodeStream30485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getBinaryStream30486;
		global::java.io.InputStream java.sql.ResultSet.getBinaryStream(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getBinaryStream30486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getBinaryStream30486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getBinaryStream30487;
		global::java.io.InputStream java.sql.ResultSet.getBinaryStream(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getBinaryStream30487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getBinaryStream30487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getWarnings30488;
		global::java.sql.SQLWarning java.sql.ResultSet.getWarnings()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getWarnings30488)) as java.sql.SQLWarning;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getWarnings30488)) as java.sql.SQLWarning;
		}
		internal static global::MonoJavaBridge.MethodId _clearWarnings30489;
		void java.sql.ResultSet.clearWarnings()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._clearWarnings30489);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._clearWarnings30489);
		}
		internal static global::MonoJavaBridge.MethodId _getCursorName30490;
		global::java.lang.String java.sql.ResultSet.getCursorName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getCursorName30490)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getCursorName30490)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getMetaData30491;
		global::java.sql.ResultSetMetaData java.sql.ResultSet.getMetaData()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSetMetaData>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getMetaData30491)) as java.sql.ResultSetMetaData;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSetMetaData>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getMetaData30491)) as java.sql.ResultSetMetaData;
		}
		internal static global::MonoJavaBridge.MethodId _findColumn30492;
		int java.sql.ResultSet.findColumn(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.sql.RowSet_._findColumn30492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._findColumn30492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCharacterStream30493;
		global::java.io.Reader java.sql.ResultSet.getCharacterStream(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getCharacterStream30493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getCharacterStream30493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
		}
		internal static global::MonoJavaBridge.MethodId _getCharacterStream30494;
		global::java.io.Reader java.sql.ResultSet.getCharacterStream(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getCharacterStream30494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getCharacterStream30494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
		}
		internal static global::MonoJavaBridge.MethodId _beforeFirst30495;
		void java.sql.ResultSet.beforeFirst()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._beforeFirst30495);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._beforeFirst30495);
		}
		internal static global::MonoJavaBridge.MethodId _afterLast30496;
		void java.sql.ResultSet.afterLast()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._afterLast30496);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._afterLast30496);
		}
		internal static global::MonoJavaBridge.MethodId _getRow30497;
		int java.sql.ResultSet.getRow()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.sql.RowSet_._getRow30497);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getRow30497);
		}
		internal static global::MonoJavaBridge.MethodId _absolute30498;
		bool java.sql.ResultSet.absolute(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_._absolute30498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._absolute30498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _relative30499;
		bool java.sql.ResultSet.relative(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_._relative30499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._relative30499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFetchDirection30500;
		void java.sql.ResultSet.setFetchDirection(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setFetchDirection30500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setFetchDirection30500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFetchDirection30501;
		int java.sql.ResultSet.getFetchDirection()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.sql.RowSet_._getFetchDirection30501);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getFetchDirection30501);
		}
		internal static global::MonoJavaBridge.MethodId _setFetchSize30502;
		void java.sql.ResultSet.setFetchSize(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setFetchSize30502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setFetchSize30502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFetchSize30503;
		int java.sql.ResultSet.getFetchSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.sql.RowSet_._getFetchSize30503);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getFetchSize30503);
		}
		internal static global::MonoJavaBridge.MethodId _getConcurrency30504;
		int java.sql.ResultSet.getConcurrency()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.sql.RowSet_._getConcurrency30504);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getConcurrency30504);
		}
		internal static global::MonoJavaBridge.MethodId _rowUpdated30505;
		bool java.sql.ResultSet.rowUpdated()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_._rowUpdated30505);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._rowUpdated30505);
		}
		internal static global::MonoJavaBridge.MethodId _rowInserted30506;
		bool java.sql.ResultSet.rowInserted()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_._rowInserted30506);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._rowInserted30506);
		}
		internal static global::MonoJavaBridge.MethodId _rowDeleted30507;
		bool java.sql.ResultSet.rowDeleted()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_._rowDeleted30507);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._rowDeleted30507);
		}
		internal static global::MonoJavaBridge.MethodId _updateNull30508;
		void java.sql.ResultSet.updateNull(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateNull30508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateNull30508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _updateNull30509;
		void java.sql.ResultSet.updateNull(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateNull30509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateNull30509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _updateBoolean30510;
		void java.sql.ResultSet.updateBoolean(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateBoolean30510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateBoolean30510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateBoolean30511;
		void java.sql.ResultSet.updateBoolean(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateBoolean30511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateBoolean30511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateByte30512;
		void java.sql.ResultSet.updateByte(int arg0, byte arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateByte30512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateByte30512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateByte30513;
		void java.sql.ResultSet.updateByte(java.lang.String arg0, byte arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateByte30513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateByte30513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateBigDecimal30514;
		void java.sql.ResultSet.updateBigDecimal(int arg0, java.math.BigDecimal arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateBigDecimal30514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateBigDecimal30514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateBigDecimal30515;
		void java.sql.ResultSet.updateBigDecimal(java.lang.String arg0, java.math.BigDecimal arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateBigDecimal30515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateBigDecimal30515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateTimestamp30516;
		void java.sql.ResultSet.updateTimestamp(java.lang.String arg0, java.sql.Timestamp arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateTimestamp30516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateTimestamp30516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateTimestamp30517;
		void java.sql.ResultSet.updateTimestamp(int arg0, java.sql.Timestamp arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateTimestamp30517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateTimestamp30517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateAsciiStream30518;
		void java.sql.ResultSet.updateAsciiStream(java.lang.String arg0, java.io.InputStream arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateAsciiStream30518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateAsciiStream30518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateAsciiStream30519;
		void java.sql.ResultSet.updateAsciiStream(java.lang.String arg0, java.io.InputStream arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateAsciiStream30519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateAsciiStream30519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateAsciiStream30520;
		void java.sql.ResultSet.updateAsciiStream(int arg0, java.io.InputStream arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateAsciiStream30520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateAsciiStream30520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateAsciiStream30521;
		void java.sql.ResultSet.updateAsciiStream(java.lang.String arg0, java.io.InputStream arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateAsciiStream30521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateAsciiStream30521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateAsciiStream30522;
		void java.sql.ResultSet.updateAsciiStream(int arg0, java.io.InputStream arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateAsciiStream30522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateAsciiStream30522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateAsciiStream30523;
		void java.sql.ResultSet.updateAsciiStream(int arg0, java.io.InputStream arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateAsciiStream30523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateAsciiStream30523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateBinaryStream30524;
		void java.sql.ResultSet.updateBinaryStream(java.lang.String arg0, java.io.InputStream arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateBinaryStream30524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateBinaryStream30524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateBinaryStream30525;
		void java.sql.ResultSet.updateBinaryStream(int arg0, java.io.InputStream arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateBinaryStream30525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateBinaryStream30525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateBinaryStream30526;
		void java.sql.ResultSet.updateBinaryStream(int arg0, java.io.InputStream arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateBinaryStream30526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateBinaryStream30526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateBinaryStream30527;
		void java.sql.ResultSet.updateBinaryStream(java.lang.String arg0, java.io.InputStream arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateBinaryStream30527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateBinaryStream30527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateBinaryStream30528;
		void java.sql.ResultSet.updateBinaryStream(int arg0, java.io.InputStream arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateBinaryStream30528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateBinaryStream30528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateBinaryStream30529;
		void java.sql.ResultSet.updateBinaryStream(java.lang.String arg0, java.io.InputStream arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateBinaryStream30529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateBinaryStream30529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateCharacterStream30530;
		void java.sql.ResultSet.updateCharacterStream(java.lang.String arg0, java.io.Reader arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateCharacterStream30530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateCharacterStream30530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateCharacterStream30531;
		void java.sql.ResultSet.updateCharacterStream(int arg0, java.io.Reader arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateCharacterStream30531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateCharacterStream30531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateCharacterStream30532;
		void java.sql.ResultSet.updateCharacterStream(int arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateCharacterStream30532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateCharacterStream30532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateCharacterStream30533;
		void java.sql.ResultSet.updateCharacterStream(java.lang.String arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateCharacterStream30533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateCharacterStream30533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateCharacterStream30534;
		void java.sql.ResultSet.updateCharacterStream(int arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateCharacterStream30534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateCharacterStream30534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateCharacterStream30535;
		void java.sql.ResultSet.updateCharacterStream(java.lang.String arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateCharacterStream30535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateCharacterStream30535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateObject30536;
		void java.sql.ResultSet.updateObject(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateObject30536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateObject30536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateObject30537;
		void java.sql.ResultSet.updateObject(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateObject30537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateObject30537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateObject30538;
		void java.sql.ResultSet.updateObject(int arg0, java.lang.Object arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateObject30538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateObject30538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateObject30539;
		void java.sql.ResultSet.updateObject(java.lang.String arg0, java.lang.Object arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateObject30539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateObject30539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _insertRow30540;
		void java.sql.ResultSet.insertRow()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._insertRow30540);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._insertRow30540);
		}
		internal static global::MonoJavaBridge.MethodId _updateRow30541;
		void java.sql.ResultSet.updateRow()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateRow30541);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateRow30541);
		}
		internal static global::MonoJavaBridge.MethodId _refreshRow30542;
		void java.sql.ResultSet.refreshRow()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._refreshRow30542);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._refreshRow30542);
		}
		internal static global::MonoJavaBridge.MethodId _cancelRowUpdates30543;
		void java.sql.ResultSet.cancelRowUpdates()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._cancelRowUpdates30543);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._cancelRowUpdates30543);
		}
		internal static global::MonoJavaBridge.MethodId _moveToInsertRow30544;
		void java.sql.ResultSet.moveToInsertRow()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._moveToInsertRow30544);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._moveToInsertRow30544);
		}
		internal static global::MonoJavaBridge.MethodId _moveToCurrentRow30545;
		void java.sql.ResultSet.moveToCurrentRow()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._moveToCurrentRow30545);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._moveToCurrentRow30545);
		}
		internal static global::MonoJavaBridge.MethodId _getStatement30546;
		global::java.sql.Statement java.sql.ResultSet.getStatement()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Statement>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getStatement30546)) as java.sql.Statement;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Statement>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getStatement30546)) as java.sql.Statement;
		}
		internal static global::MonoJavaBridge.MethodId _getClob30547;
		global::java.sql.Clob java.sql.ResultSet.getClob(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Clob>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getClob30547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Clob;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Clob>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getClob30547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Clob;
		}
		internal static global::MonoJavaBridge.MethodId _getClob30548;
		global::java.sql.Clob java.sql.ResultSet.getClob(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Clob>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getClob30548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Clob;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Clob>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getClob30548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Clob;
		}
		internal static global::MonoJavaBridge.MethodId _updateRef30549;
		void java.sql.ResultSet.updateRef(java.lang.String arg0, java.sql.Ref arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateRef30549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateRef30549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateRef30550;
		void java.sql.ResultSet.updateRef(int arg0, java.sql.Ref arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateRef30550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateRef30550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateClob30551;
		void java.sql.ResultSet.updateClob(java.lang.String arg0, java.sql.Clob arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateClob30551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateClob30551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateClob30552;
		void java.sql.ResultSet.updateClob(int arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateClob30552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateClob30552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateClob30553;
		void java.sql.ResultSet.updateClob(java.lang.String arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateClob30553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateClob30553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateClob30554;
		void java.sql.ResultSet.updateClob(int arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateClob30554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateClob30554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateClob30555;
		void java.sql.ResultSet.updateClob(java.lang.String arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateClob30555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateClob30555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateClob30556;
		void java.sql.ResultSet.updateClob(int arg0, java.sql.Clob arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateClob30556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateClob30556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateArray30557;
		void java.sql.ResultSet.updateArray(int arg0, java.sql.Array arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateArray30557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateArray30557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateArray30558;
		void java.sql.ResultSet.updateArray(java.lang.String arg0, java.sql.Array arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateArray30558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateArray30558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getHoldability30559;
		int java.sql.ResultSet.getHoldability()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.sql.RowSet_._getHoldability30559);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getHoldability30559);
		}
		internal static global::MonoJavaBridge.MethodId _updateNString30560;
		void java.sql.ResultSet.updateNString(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateNString30560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateNString30560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateNString30561;
		void java.sql.ResultSet.updateNString(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateNString30561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateNString30561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateNClob30562;
		void java.sql.ResultSet.updateNClob(int arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateNClob30562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateNClob30562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateNClob30563;
		void java.sql.ResultSet.updateNClob(int arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateNClob30563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateNClob30563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateNClob30564;
		void java.sql.ResultSet.updateNClob(java.lang.String arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateNClob30564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateNClob30564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateNClob30565;
		void java.sql.ResultSet.updateNClob(java.lang.String arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateNClob30565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateNClob30565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getNString30566;
		global::java.lang.String java.sql.ResultSet.getNString(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getNString30566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getNString30566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNString30567;
		global::java.lang.String java.sql.ResultSet.getNString(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getNString30567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getNString30567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNCharacterStream30568;
		global::java.io.Reader java.sql.ResultSet.getNCharacterStream(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getNCharacterStream30568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getNCharacterStream30568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
		}
		internal static global::MonoJavaBridge.MethodId _getNCharacterStream30569;
		global::java.io.Reader java.sql.ResultSet.getNCharacterStream(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getNCharacterStream30569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getNCharacterStream30569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
		}
		internal static global::MonoJavaBridge.MethodId _updateNCharacterStream30570;
		void java.sql.ResultSet.updateNCharacterStream(int arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateNCharacterStream30570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateNCharacterStream30570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateNCharacterStream30571;
		void java.sql.ResultSet.updateNCharacterStream(java.lang.String arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateNCharacterStream30571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateNCharacterStream30571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateNCharacterStream30572;
		void java.sql.ResultSet.updateNCharacterStream(int arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateNCharacterStream30572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateNCharacterStream30572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateNCharacterStream30573;
		void java.sql.ResultSet.updateNCharacterStream(java.lang.String arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateNCharacterStream30573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateNCharacterStream30573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static RowSet_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.sql.RowSet_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/sql/RowSet"));
			global::javax.sql.RowSet_._setReadOnly30290 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setReadOnly", "(Z)V");
			global::javax.sql.RowSet_._setBoolean30291 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setBoolean", "(Ljava/lang/String;Z)V");
			global::javax.sql.RowSet_._setBoolean30292 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setBoolean", "(IZ)V");
			global::javax.sql.RowSet_._setByte30293 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setByte", "(Ljava/lang/String;B)V");
			global::javax.sql.RowSet_._setByte30294 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setByte", "(IB)V");
			global::javax.sql.RowSet_._setShort30295 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setShort", "(IS)V");
			global::javax.sql.RowSet_._setShort30296 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setShort", "(Ljava/lang/String;S)V");
			global::javax.sql.RowSet_._setInt30297 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setInt", "(Ljava/lang/String;I)V");
			global::javax.sql.RowSet_._setInt30298 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setInt", "(II)V");
			global::javax.sql.RowSet_._setLong30299 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setLong", "(IJ)V");
			global::javax.sql.RowSet_._setLong30300 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setLong", "(Ljava/lang/String;J)V");
			global::javax.sql.RowSet_._setFloat30301 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setFloat", "(Ljava/lang/String;F)V");
			global::javax.sql.RowSet_._setFloat30302 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setFloat", "(IF)V");
			global::javax.sql.RowSet_._setDouble30303 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setDouble", "(ID)V");
			global::javax.sql.RowSet_._setDouble30304 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setDouble", "(Ljava/lang/String;D)V");
			global::javax.sql.RowSet_._isReadOnly30305 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "isReadOnly", "()Z");
			global::javax.sql.RowSet_._setTimestamp30306 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setTimestamp", "(ILjava/sql/Timestamp;Ljava/util/Calendar;)V");
			global::javax.sql.RowSet_._setTimestamp30307 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setTimestamp", "(Ljava/lang/String;Ljava/sql/Timestamp;Ljava/util/Calendar;)V");
			global::javax.sql.RowSet_._setTimestamp30308 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setTimestamp", "(ILjava/sql/Timestamp;)V");
			global::javax.sql.RowSet_._setTimestamp30309 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setTimestamp", "(Ljava/lang/String;Ljava/sql/Timestamp;)V");
			global::javax.sql.RowSet_._setURL30310 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setURL", "(ILjava/net/URL;)V");
			global::javax.sql.RowSet_._setTime30311 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setTime", "(Ljava/lang/String;Ljava/sql/Time;Ljava/util/Calendar;)V");
			global::javax.sql.RowSet_._setTime30312 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setTime", "(Ljava/lang/String;Ljava/sql/Time;)V");
			global::javax.sql.RowSet_._setTime30313 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setTime", "(ILjava/sql/Time;Ljava/util/Calendar;)V");
			global::javax.sql.RowSet_._setTime30314 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setTime", "(ILjava/sql/Time;)V");
			global::javax.sql.RowSet_._setDate30315 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setDate", "(ILjava/sql/Date;Ljava/util/Calendar;)V");
			global::javax.sql.RowSet_._setDate30316 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setDate", "(ILjava/sql/Date;)V");
			global::javax.sql.RowSet_._setDate30317 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setDate", "(Ljava/lang/String;Ljava/sql/Date;Ljava/util/Calendar;)V");
			global::javax.sql.RowSet_._setDate30318 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setDate", "(Ljava/lang/String;Ljava/sql/Date;)V");
			global::javax.sql.RowSet_._execute30319 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "execute", "()V");
			global::javax.sql.RowSet_._setPassword30320 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setPassword", "(Ljava/lang/String;)V");
			global::javax.sql.RowSet_._setType30321 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setType", "(I)V");
			global::javax.sql.RowSet_._getPassword30322 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getPassword", "()Ljava/lang/String;");
			global::javax.sql.RowSet_._setString30323 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setString", "(ILjava/lang/String;)V");
			global::javax.sql.RowSet_._setString30324 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setString", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::javax.sql.RowSet_._setObject30325 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setObject", "(Ljava/lang/String;Ljava/lang/Object;II)V");
			global::javax.sql.RowSet_._setObject30326 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setObject", "(ILjava/lang/Object;II)V");
			global::javax.sql.RowSet_._setObject30327 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setObject", "(ILjava/lang/Object;I)V");
			global::javax.sql.RowSet_._setObject30328 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setObject", "(Ljava/lang/String;Ljava/lang/Object;I)V");
			global::javax.sql.RowSet_._setObject30329 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setObject", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::javax.sql.RowSet_._setObject30330 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setObject", "(ILjava/lang/Object;)V");
			global::javax.sql.RowSet_._getUrl30331 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getUrl", "()Ljava/lang/String;");
			global::javax.sql.RowSet_._setUrl30332 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setUrl", "(Ljava/lang/String;)V");
			global::javax.sql.RowSet_._setBytes30333 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setBytes", "(Ljava/lang/String;[B)V");
			global::javax.sql.RowSet_._setBytes30334 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setBytes", "(I[B)V");
			global::javax.sql.RowSet_._setBinaryStream30335 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;I)V");
			global::javax.sql.RowSet_._setBinaryStream30336 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setBinaryStream", "(ILjava/io/InputStream;I)V");
			global::javax.sql.RowSet_._setBinaryStream30337 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;)V");
			global::javax.sql.RowSet_._setBinaryStream30338 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setBinaryStream", "(ILjava/io/InputStream;)V");
			global::javax.sql.RowSet_._setNull30339 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setNull", "(Ljava/lang/String;ILjava/lang/String;)V");
			global::javax.sql.RowSet_._setNull30340 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setNull", "(IILjava/lang/String;)V");
			global::javax.sql.RowSet_._setNull30341 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setNull", "(II)V");
			global::javax.sql.RowSet_._setNull30342 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setNull", "(Ljava/lang/String;I)V");
			global::javax.sql.RowSet_._setBigDecimal30343 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setBigDecimal", "(Ljava/lang/String;Ljava/math/BigDecimal;)V");
			global::javax.sql.RowSet_._setBigDecimal30344 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setBigDecimal", "(ILjava/math/BigDecimal;)V");
			global::javax.sql.RowSet_._setAsciiStream30345 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setAsciiStream", "(ILjava/io/InputStream;I)V");
			global::javax.sql.RowSet_._setAsciiStream30346 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;I)V");
			global::javax.sql.RowSet_._setAsciiStream30347 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setAsciiStream", "(ILjava/io/InputStream;)V");
			global::javax.sql.RowSet_._setAsciiStream30348 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;)V");
			global::javax.sql.RowSet_._setCharacterStream30349 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;I)V");
			global::javax.sql.RowSet_._setCharacterStream30350 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;)V");
			global::javax.sql.RowSet_._setCharacterStream30351 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setCharacterStream", "(ILjava/io/Reader;)V");
			global::javax.sql.RowSet_._setCharacterStream30352 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setCharacterStream", "(ILjava/io/Reader;I)V");
			global::javax.sql.RowSet_._setNString30353 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setNString", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::javax.sql.RowSet_._setNString30354 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setNString", "(ILjava/lang/String;)V");
			global::javax.sql.RowSet_._setNCharacterStream30355 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setNCharacterStream", "(ILjava/io/Reader;J)V");
			global::javax.sql.RowSet_._setNCharacterStream30356 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setNCharacterStream", "(ILjava/io/Reader;)V");
			global::javax.sql.RowSet_._setNCharacterStream30357 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setNCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;J)V");
			global::javax.sql.RowSet_._setNCharacterStream30358 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setNCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;)V");
			global::javax.sql.RowSet_._setNClob30359 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setNClob", "(Ljava/lang/String;Ljava/io/Reader;)V");
			global::javax.sql.RowSet_._setNClob30360 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setNClob", "(ILjava/io/Reader;)V");
			global::javax.sql.RowSet_._setNClob30361 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setNClob", "(Ljava/lang/String;Ljava/io/Reader;J)V");
			global::javax.sql.RowSet_._setNClob30362 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setNClob", "(ILjava/io/Reader;J)V");
			global::javax.sql.RowSet_._setClob30363 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setClob", "(Ljava/lang/String;Ljava/io/Reader;J)V");
			global::javax.sql.RowSet_._setClob30364 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setClob", "(Ljava/lang/String;Ljava/sql/Clob;)V");
			global::javax.sql.RowSet_._setClob30365 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setClob", "(Ljava/lang/String;Ljava/io/Reader;)V");
			global::javax.sql.RowSet_._setClob30366 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setClob", "(ILjava/sql/Clob;)V");
			global::javax.sql.RowSet_._setClob30367 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setClob", "(ILjava/io/Reader;J)V");
			global::javax.sql.RowSet_._setClob30368 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setClob", "(ILjava/io/Reader;)V");
			global::javax.sql.RowSet_._setBlob30369 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setBlob", "(ILjava/io/InputStream;)V");
			global::javax.sql.RowSet_._setBlob30370 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setBlob", "(Ljava/lang/String;Ljava/sql/Blob;)V");
			global::javax.sql.RowSet_._setBlob30371 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setBlob", "(Ljava/lang/String;Ljava/io/InputStream;)V");
			global::javax.sql.RowSet_._setBlob30372 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setBlob", "(ILjava/sql/Blob;)V");
			global::javax.sql.RowSet_._setBlob30373 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setBlob", "(ILjava/io/InputStream;J)V");
			global::javax.sql.RowSet_._setBlob30374 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setBlob", "(Ljava/lang/String;Ljava/io/InputStream;J)V");
			global::javax.sql.RowSet_._clearParameters30375 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "clearParameters", "()V");
			global::javax.sql.RowSet_._setRef30376 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setRef", "(ILjava/sql/Ref;)V");
			global::javax.sql.RowSet_._setArray30377 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setArray", "(ILjava/sql/Array;)V");
			global::javax.sql.RowSet_._getMaxFieldSize30378 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getMaxFieldSize", "()I");
			global::javax.sql.RowSet_._setMaxFieldSize30379 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setMaxFieldSize", "(I)V");
			global::javax.sql.RowSet_._getMaxRows30380 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getMaxRows", "()I");
			global::javax.sql.RowSet_._setMaxRows30381 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setMaxRows", "(I)V");
			global::javax.sql.RowSet_._setEscapeProcessing30382 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setEscapeProcessing", "(Z)V");
			global::javax.sql.RowSet_._getQueryTimeout30383 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getQueryTimeout", "()I");
			global::javax.sql.RowSet_._setQueryTimeout30384 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setQueryTimeout", "(I)V");
			global::javax.sql.RowSet_._setTransactionIsolation30385 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setTransactionIsolation", "(I)V");
			global::javax.sql.RowSet_._getTransactionIsolation30386 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getTransactionIsolation", "()I");
			global::javax.sql.RowSet_._getTypeMap30387 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getTypeMap", "()Ljava/util/Map;");
			global::javax.sql.RowSet_._setTypeMap30388 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setTypeMap", "(Ljava/util/Map;)V");
			global::javax.sql.RowSet_._getDataSourceName30389 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getDataSourceName", "()Ljava/lang/String;");
			global::javax.sql.RowSet_._setDataSourceName30390 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setDataSourceName", "(Ljava/lang/String;)V");
			global::javax.sql.RowSet_._getUsername30391 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getUsername", "()Ljava/lang/String;");
			global::javax.sql.RowSet_._setUsername30392 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setUsername", "(Ljava/lang/String;)V");
			global::javax.sql.RowSet_._getCommand30393 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getCommand", "()Ljava/lang/String;");
			global::javax.sql.RowSet_._setCommand30394 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setCommand", "(Ljava/lang/String;)V");
			global::javax.sql.RowSet_._getEscapeProcessing30395 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getEscapeProcessing", "()Z");
			global::javax.sql.RowSet_._setConcurrency30396 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setConcurrency", "(I)V");
			global::javax.sql.RowSet_._addRowSetListener30397 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "addRowSetListener", "(Ljavax/sql/RowSetListener;)V");
			global::javax.sql.RowSet_._removeRowSetListener30398 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "removeRowSetListener", "(Ljavax/sql/RowSetListener;)V");
			global::javax.sql.RowSet_._getObject30399 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getObject", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::javax.sql.RowSet_._getObject30400 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getObject", "(ILjava/util/Map;)Ljava/lang/Object;");
			global::javax.sql.RowSet_._getObject30401 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getObject", "(I)Ljava/lang/Object;");
			global::javax.sql.RowSet_._getObject30402 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getObject", "(Ljava/lang/String;Ljava/util/Map;)Ljava/lang/Object;");
			global::javax.sql.RowSet_._getBoolean30403 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getBoolean", "(Ljava/lang/String;)Z");
			global::javax.sql.RowSet_._getBoolean30404 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getBoolean", "(I)Z");
			global::javax.sql.RowSet_._getByte30405 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getByte", "(Ljava/lang/String;)B");
			global::javax.sql.RowSet_._getByte30406 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getByte", "(I)B");
			global::javax.sql.RowSet_._getShort30407 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getShort", "(I)S");
			global::javax.sql.RowSet_._getShort30408 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getShort", "(Ljava/lang/String;)S");
			global::javax.sql.RowSet_._getInt30409 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getInt", "(Ljava/lang/String;)I");
			global::javax.sql.RowSet_._getInt30410 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getInt", "(I)I");
			global::javax.sql.RowSet_._getLong30411 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getLong", "(Ljava/lang/String;)J");
			global::javax.sql.RowSet_._getLong30412 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getLong", "(I)J");
			global::javax.sql.RowSet_._getFloat30413 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getFloat", "(Ljava/lang/String;)F");
			global::javax.sql.RowSet_._getFloat30414 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getFloat", "(I)F");
			global::javax.sql.RowSet_._getDouble30415 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getDouble", "(I)D");
			global::javax.sql.RowSet_._getDouble30416 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getDouble", "(Ljava/lang/String;)D");
			global::javax.sql.RowSet_._getBytes30417 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getBytes", "(Ljava/lang/String;)[B");
			global::javax.sql.RowSet_._getBytes30418 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getBytes", "(I)[B");
			global::javax.sql.RowSet_._getArray30419 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getArray", "(Ljava/lang/String;)Ljava/sql/Array;");
			global::javax.sql.RowSet_._getArray30420 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getArray", "(I)Ljava/sql/Array;");
			global::javax.sql.RowSet_._next30421 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "next", "()Z");
			global::javax.sql.RowSet_._getURL30422 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getURL", "(Ljava/lang/String;)Ljava/net/URL;");
			global::javax.sql.RowSet_._getURL30423 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getURL", "(I)Ljava/net/URL;");
			global::javax.sql.RowSet_._close30424 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "close", "()V");
			global::javax.sql.RowSet_._getType30425 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getType", "()I");
			global::javax.sql.RowSet_._previous30426 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "previous", "()Z");
			global::javax.sql.RowSet_._getRef30427 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getRef", "(I)Ljava/sql/Ref;");
			global::javax.sql.RowSet_._getRef30428 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getRef", "(Ljava/lang/String;)Ljava/sql/Ref;");
			global::javax.sql.RowSet_._getString30429 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getString", "(Ljava/lang/String;)Ljava/lang/String;");
			global::javax.sql.RowSet_._getString30430 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getString", "(I)Ljava/lang/String;");
			global::javax.sql.RowSet_._isFirst30431 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "isFirst", "()Z");
			global::javax.sql.RowSet_._getTime30432 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getTime", "(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Time;");
			global::javax.sql.RowSet_._getTime30433 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getTime", "(Ljava/lang/String;)Ljava/sql/Time;");
			global::javax.sql.RowSet_._getTime30434 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getTime", "(ILjava/util/Calendar;)Ljava/sql/Time;");
			global::javax.sql.RowSet_._getTime30435 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getTime", "(I)Ljava/sql/Time;");
			global::javax.sql.RowSet_._getDate30436 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getDate", "(Ljava/lang/String;)Ljava/sql/Date;");
			global::javax.sql.RowSet_._getDate30437 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getDate", "(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Date;");
			global::javax.sql.RowSet_._getDate30438 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getDate", "(I)Ljava/sql/Date;");
			global::javax.sql.RowSet_._getDate30439 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getDate", "(ILjava/util/Calendar;)Ljava/sql/Date;");
			global::javax.sql.RowSet_._isClosed30440 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "isClosed", "()Z");
			global::javax.sql.RowSet_._getTimestamp30441 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getTimestamp", "(Ljava/lang/String;)Ljava/sql/Timestamp;");
			global::javax.sql.RowSet_._getTimestamp30442 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getTimestamp", "(ILjava/util/Calendar;)Ljava/sql/Timestamp;");
			global::javax.sql.RowSet_._getTimestamp30443 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getTimestamp", "(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Timestamp;");
			global::javax.sql.RowSet_._getTimestamp30444 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getTimestamp", "(I)Ljava/sql/Timestamp;");
			global::javax.sql.RowSet_._last30445 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "last", "()Z");
			global::javax.sql.RowSet_._first30446 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "first", "()Z");
			global::javax.sql.RowSet_._updateBytes30447 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateBytes", "(Ljava/lang/String;[B)V");
			global::javax.sql.RowSet_._updateBytes30448 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateBytes", "(I[B)V");
			global::javax.sql.RowSet_._isLast30449 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "isLast", "()Z");
			global::javax.sql.RowSet_._isBeforeFirst30450 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "isBeforeFirst", "()Z");
			global::javax.sql.RowSet_._isAfterLast30451 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "isAfterLast", "()Z");
			global::javax.sql.RowSet_._getBlob30452 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getBlob", "(Ljava/lang/String;)Ljava/sql/Blob;");
			global::javax.sql.RowSet_._getBlob30453 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getBlob", "(I)Ljava/sql/Blob;");
			global::javax.sql.RowSet_._updateDate30454 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateDate", "(ILjava/sql/Date;)V");
			global::javax.sql.RowSet_._updateDate30455 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateDate", "(Ljava/lang/String;Ljava/sql/Date;)V");
			global::javax.sql.RowSet_._updateTime30456 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateTime", "(ILjava/sql/Time;)V");
			global::javax.sql.RowSet_._updateTime30457 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateTime", "(Ljava/lang/String;Ljava/sql/Time;)V");
			global::javax.sql.RowSet_._deleteRow30458 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "deleteRow", "()V");
			global::javax.sql.RowSet_._updateBlob30459 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateBlob", "(Ljava/lang/String;Ljava/sql/Blob;)V");
			global::javax.sql.RowSet_._updateBlob30460 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateBlob", "(Ljava/lang/String;Ljava/io/InputStream;J)V");
			global::javax.sql.RowSet_._updateBlob30461 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateBlob", "(ILjava/io/InputStream;)V");
			global::javax.sql.RowSet_._updateBlob30462 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateBlob", "(ILjava/io/InputStream;J)V");
			global::javax.sql.RowSet_._updateBlob30463 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateBlob", "(Ljava/lang/String;Ljava/io/InputStream;)V");
			global::javax.sql.RowSet_._updateBlob30464 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateBlob", "(ILjava/sql/Blob;)V");
			global::javax.sql.RowSet_._updateDouble30465 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateDouble", "(ID)V");
			global::javax.sql.RowSet_._updateDouble30466 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateDouble", "(Ljava/lang/String;D)V");
			global::javax.sql.RowSet_._updateFloat30467 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateFloat", "(Ljava/lang/String;F)V");
			global::javax.sql.RowSet_._updateFloat30468 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateFloat", "(IF)V");
			global::javax.sql.RowSet_._updateInt30469 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateInt", "(Ljava/lang/String;I)V");
			global::javax.sql.RowSet_._updateInt30470 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateInt", "(II)V");
			global::javax.sql.RowSet_._updateLong30471 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateLong", "(Ljava/lang/String;J)V");
			global::javax.sql.RowSet_._updateLong30472 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateLong", "(IJ)V");
			global::javax.sql.RowSet_._updateShort30473 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateShort", "(IS)V");
			global::javax.sql.RowSet_._updateShort30474 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateShort", "(Ljava/lang/String;S)V");
			global::javax.sql.RowSet_._updateString30475 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateString", "(ILjava/lang/String;)V");
			global::javax.sql.RowSet_._updateString30476 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateString", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::javax.sql.RowSet_._wasNull30477 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "wasNull", "()Z");
			global::javax.sql.RowSet_._getBigDecimal30478 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getBigDecimal", "(II)Ljava/math/BigDecimal;");
			global::javax.sql.RowSet_._getBigDecimal30479 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getBigDecimal", "(I)Ljava/math/BigDecimal;");
			global::javax.sql.RowSet_._getBigDecimal30480 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getBigDecimal", "(Ljava/lang/String;)Ljava/math/BigDecimal;");
			global::javax.sql.RowSet_._getBigDecimal30481 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getBigDecimal", "(Ljava/lang/String;I)Ljava/math/BigDecimal;");
			global::javax.sql.RowSet_._getAsciiStream30482 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getAsciiStream", "(Ljava/lang/String;)Ljava/io/InputStream;");
			global::javax.sql.RowSet_._getAsciiStream30483 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getAsciiStream", "(I)Ljava/io/InputStream;");
			global::javax.sql.RowSet_._getUnicodeStream30484 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getUnicodeStream", "(Ljava/lang/String;)Ljava/io/InputStream;");
			global::javax.sql.RowSet_._getUnicodeStream30485 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getUnicodeStream", "(I)Ljava/io/InputStream;");
			global::javax.sql.RowSet_._getBinaryStream30486 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getBinaryStream", "(I)Ljava/io/InputStream;");
			global::javax.sql.RowSet_._getBinaryStream30487 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getBinaryStream", "(Ljava/lang/String;)Ljava/io/InputStream;");
			global::javax.sql.RowSet_._getWarnings30488 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getWarnings", "()Ljava/sql/SQLWarning;");
			global::javax.sql.RowSet_._clearWarnings30489 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "clearWarnings", "()V");
			global::javax.sql.RowSet_._getCursorName30490 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getCursorName", "()Ljava/lang/String;");
			global::javax.sql.RowSet_._getMetaData30491 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getMetaData", "()Ljava/sql/ResultSetMetaData;");
			global::javax.sql.RowSet_._findColumn30492 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "findColumn", "(Ljava/lang/String;)I");
			global::javax.sql.RowSet_._getCharacterStream30493 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getCharacterStream", "(Ljava/lang/String;)Ljava/io/Reader;");
			global::javax.sql.RowSet_._getCharacterStream30494 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getCharacterStream", "(I)Ljava/io/Reader;");
			global::javax.sql.RowSet_._beforeFirst30495 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "beforeFirst", "()V");
			global::javax.sql.RowSet_._afterLast30496 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "afterLast", "()V");
			global::javax.sql.RowSet_._getRow30497 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getRow", "()I");
			global::javax.sql.RowSet_._absolute30498 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "absolute", "(I)Z");
			global::javax.sql.RowSet_._relative30499 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "relative", "(I)Z");
			global::javax.sql.RowSet_._setFetchDirection30500 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setFetchDirection", "(I)V");
			global::javax.sql.RowSet_._getFetchDirection30501 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getFetchDirection", "()I");
			global::javax.sql.RowSet_._setFetchSize30502 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setFetchSize", "(I)V");
			global::javax.sql.RowSet_._getFetchSize30503 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getFetchSize", "()I");
			global::javax.sql.RowSet_._getConcurrency30504 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getConcurrency", "()I");
			global::javax.sql.RowSet_._rowUpdated30505 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "rowUpdated", "()Z");
			global::javax.sql.RowSet_._rowInserted30506 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "rowInserted", "()Z");
			global::javax.sql.RowSet_._rowDeleted30507 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "rowDeleted", "()Z");
			global::javax.sql.RowSet_._updateNull30508 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateNull", "(Ljava/lang/String;)V");
			global::javax.sql.RowSet_._updateNull30509 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateNull", "(I)V");
			global::javax.sql.RowSet_._updateBoolean30510 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateBoolean", "(IZ)V");
			global::javax.sql.RowSet_._updateBoolean30511 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateBoolean", "(Ljava/lang/String;Z)V");
			global::javax.sql.RowSet_._updateByte30512 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateByte", "(IB)V");
			global::javax.sql.RowSet_._updateByte30513 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateByte", "(Ljava/lang/String;B)V");
			global::javax.sql.RowSet_._updateBigDecimal30514 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateBigDecimal", "(ILjava/math/BigDecimal;)V");
			global::javax.sql.RowSet_._updateBigDecimal30515 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateBigDecimal", "(Ljava/lang/String;Ljava/math/BigDecimal;)V");
			global::javax.sql.RowSet_._updateTimestamp30516 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateTimestamp", "(Ljava/lang/String;Ljava/sql/Timestamp;)V");
			global::javax.sql.RowSet_._updateTimestamp30517 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateTimestamp", "(ILjava/sql/Timestamp;)V");
			global::javax.sql.RowSet_._updateAsciiStream30518 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;)V");
			global::javax.sql.RowSet_._updateAsciiStream30519 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;J)V");
			global::javax.sql.RowSet_._updateAsciiStream30520 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateAsciiStream", "(ILjava/io/InputStream;J)V");
			global::javax.sql.RowSet_._updateAsciiStream30521 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;I)V");
			global::javax.sql.RowSet_._updateAsciiStream30522 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateAsciiStream", "(ILjava/io/InputStream;)V");
			global::javax.sql.RowSet_._updateAsciiStream30523 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateAsciiStream", "(ILjava/io/InputStream;I)V");
			global::javax.sql.RowSet_._updateBinaryStream30524 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;I)V");
			global::javax.sql.RowSet_._updateBinaryStream30525 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateBinaryStream", "(ILjava/io/InputStream;I)V");
			global::javax.sql.RowSet_._updateBinaryStream30526 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateBinaryStream", "(ILjava/io/InputStream;J)V");
			global::javax.sql.RowSet_._updateBinaryStream30527 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;J)V");
			global::javax.sql.RowSet_._updateBinaryStream30528 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateBinaryStream", "(ILjava/io/InputStream;)V");
			global::javax.sql.RowSet_._updateBinaryStream30529 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;)V");
			global::javax.sql.RowSet_._updateCharacterStream30530 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;I)V");
			global::javax.sql.RowSet_._updateCharacterStream30531 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateCharacterStream", "(ILjava/io/Reader;I)V");
			global::javax.sql.RowSet_._updateCharacterStream30532 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateCharacterStream", "(ILjava/io/Reader;J)V");
			global::javax.sql.RowSet_._updateCharacterStream30533 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;J)V");
			global::javax.sql.RowSet_._updateCharacterStream30534 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateCharacterStream", "(ILjava/io/Reader;)V");
			global::javax.sql.RowSet_._updateCharacterStream30535 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;)V");
			global::javax.sql.RowSet_._updateObject30536 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateObject", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::javax.sql.RowSet_._updateObject30537 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateObject", "(ILjava/lang/Object;)V");
			global::javax.sql.RowSet_._updateObject30538 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateObject", "(ILjava/lang/Object;I)V");
			global::javax.sql.RowSet_._updateObject30539 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateObject", "(Ljava/lang/String;Ljava/lang/Object;I)V");
			global::javax.sql.RowSet_._insertRow30540 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "insertRow", "()V");
			global::javax.sql.RowSet_._updateRow30541 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateRow", "()V");
			global::javax.sql.RowSet_._refreshRow30542 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "refreshRow", "()V");
			global::javax.sql.RowSet_._cancelRowUpdates30543 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "cancelRowUpdates", "()V");
			global::javax.sql.RowSet_._moveToInsertRow30544 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "moveToInsertRow", "()V");
			global::javax.sql.RowSet_._moveToCurrentRow30545 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "moveToCurrentRow", "()V");
			global::javax.sql.RowSet_._getStatement30546 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getStatement", "()Ljava/sql/Statement;");
			global::javax.sql.RowSet_._getClob30547 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getClob", "(Ljava/lang/String;)Ljava/sql/Clob;");
			global::javax.sql.RowSet_._getClob30548 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getClob", "(I)Ljava/sql/Clob;");
			global::javax.sql.RowSet_._updateRef30549 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateRef", "(Ljava/lang/String;Ljava/sql/Ref;)V");
			global::javax.sql.RowSet_._updateRef30550 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateRef", "(ILjava/sql/Ref;)V");
			global::javax.sql.RowSet_._updateClob30551 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateClob", "(Ljava/lang/String;Ljava/sql/Clob;)V");
			global::javax.sql.RowSet_._updateClob30552 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateClob", "(ILjava/io/Reader;)V");
			global::javax.sql.RowSet_._updateClob30553 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateClob", "(Ljava/lang/String;Ljava/io/Reader;)V");
			global::javax.sql.RowSet_._updateClob30554 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateClob", "(ILjava/io/Reader;J)V");
			global::javax.sql.RowSet_._updateClob30555 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateClob", "(Ljava/lang/String;Ljava/io/Reader;J)V");
			global::javax.sql.RowSet_._updateClob30556 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateClob", "(ILjava/sql/Clob;)V");
			global::javax.sql.RowSet_._updateArray30557 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateArray", "(ILjava/sql/Array;)V");
			global::javax.sql.RowSet_._updateArray30558 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateArray", "(Ljava/lang/String;Ljava/sql/Array;)V");
			global::javax.sql.RowSet_._getHoldability30559 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getHoldability", "()I");
			global::javax.sql.RowSet_._updateNString30560 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateNString", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::javax.sql.RowSet_._updateNString30561 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateNString", "(ILjava/lang/String;)V");
			global::javax.sql.RowSet_._updateNClob30562 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateNClob", "(ILjava/io/Reader;)V");
			global::javax.sql.RowSet_._updateNClob30563 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateNClob", "(ILjava/io/Reader;J)V");
			global::javax.sql.RowSet_._updateNClob30564 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateNClob", "(Ljava/lang/String;Ljava/io/Reader;J)V");
			global::javax.sql.RowSet_._updateNClob30565 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateNClob", "(Ljava/lang/String;Ljava/io/Reader;)V");
			global::javax.sql.RowSet_._getNString30566 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getNString", "(Ljava/lang/String;)Ljava/lang/String;");
			global::javax.sql.RowSet_._getNString30567 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getNString", "(I)Ljava/lang/String;");
			global::javax.sql.RowSet_._getNCharacterStream30568 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getNCharacterStream", "(I)Ljava/io/Reader;");
			global::javax.sql.RowSet_._getNCharacterStream30569 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getNCharacterStream", "(Ljava/lang/String;)Ljava/io/Reader;");
			global::javax.sql.RowSet_._updateNCharacterStream30570 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateNCharacterStream", "(ILjava/io/Reader;)V");
			global::javax.sql.RowSet_._updateNCharacterStream30571 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateNCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;J)V");
			global::javax.sql.RowSet_._updateNCharacterStream30572 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateNCharacterStream", "(ILjava/io/Reader;J)V");
			global::javax.sql.RowSet_._updateNCharacterStream30573 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateNCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
