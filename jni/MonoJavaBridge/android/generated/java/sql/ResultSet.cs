namespace java.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.sql.ResultSet_))]
	public interface ResultSet  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.Object getObject(java.lang.String arg0);
		global::java.lang.Object getObject(int arg0, java.util.Map arg1);
		global::java.lang.Object getObject(int arg0);
		global::java.lang.Object getObject(java.lang.String arg0, java.util.Map arg1);
		bool getBoolean(java.lang.String arg0);
		bool getBoolean(int arg0);
		byte getByte(java.lang.String arg0);
		byte getByte(int arg0);
		short getShort(int arg0);
		short getShort(java.lang.String arg0);
		int getInt(java.lang.String arg0);
		int getInt(int arg0);
		long getLong(java.lang.String arg0);
		long getLong(int arg0);
		float getFloat(java.lang.String arg0);
		float getFloat(int arg0);
		double getDouble(int arg0);
		double getDouble(java.lang.String arg0);
		byte[] getBytes(java.lang.String arg0);
		byte[] getBytes(int arg0);
		global::java.sql.Array getArray(java.lang.String arg0);
		global::java.sql.Array getArray(int arg0);
		bool next();
		global::java.net.URL getURL(java.lang.String arg0);
		global::java.net.URL getURL(int arg0);
		void close();
		int getType();
		bool previous();
		global::java.sql.Ref getRef(int arg0);
		global::java.sql.Ref getRef(java.lang.String arg0);
		global::java.lang.String getString(java.lang.String arg0);
		global::java.lang.String getString(int arg0);
		bool isFirst();
		global::java.sql.Time getTime(java.lang.String arg0, java.util.Calendar arg1);
		global::java.sql.Time getTime(java.lang.String arg0);
		global::java.sql.Time getTime(int arg0, java.util.Calendar arg1);
		global::java.sql.Time getTime(int arg0);
		global::java.sql.Date getDate(java.lang.String arg0);
		global::java.sql.Date getDate(java.lang.String arg0, java.util.Calendar arg1);
		global::java.sql.Date getDate(int arg0);
		global::java.sql.Date getDate(int arg0, java.util.Calendar arg1);
		bool isClosed();
		global::java.sql.Timestamp getTimestamp(java.lang.String arg0);
		global::java.sql.Timestamp getTimestamp(int arg0, java.util.Calendar arg1);
		global::java.sql.Timestamp getTimestamp(java.lang.String arg0, java.util.Calendar arg1);
		global::java.sql.Timestamp getTimestamp(int arg0);
		bool last();
		bool first();
		void updateBytes(java.lang.String arg0, byte[] arg1);
		void updateBytes(int arg0, byte[] arg1);
		bool isLast();
		bool isBeforeFirst();
		bool isAfterLast();
		global::java.sql.Blob getBlob(java.lang.String arg0);
		global::java.sql.Blob getBlob(int arg0);
		void updateDate(int arg0, java.sql.Date arg1);
		void updateDate(java.lang.String arg0, java.sql.Date arg1);
		void updateTime(int arg0, java.sql.Time arg1);
		void updateTime(java.lang.String arg0, java.sql.Time arg1);
		void deleteRow();
		void updateBlob(java.lang.String arg0, java.sql.Blob arg1);
		void updateBlob(java.lang.String arg0, java.io.InputStream arg1, long arg2);
		void updateBlob(int arg0, java.io.InputStream arg1);
		void updateBlob(int arg0, java.io.InputStream arg1, long arg2);
		void updateBlob(java.lang.String arg0, java.io.InputStream arg1);
		void updateBlob(int arg0, java.sql.Blob arg1);
		void updateDouble(int arg0, double arg1);
		void updateDouble(java.lang.String arg0, double arg1);
		void updateFloat(java.lang.String arg0, float arg1);
		void updateFloat(int arg0, float arg1);
		void updateInt(java.lang.String arg0, int arg1);
		void updateInt(int arg0, int arg1);
		void updateLong(java.lang.String arg0, long arg1);
		void updateLong(int arg0, long arg1);
		void updateShort(int arg0, short arg1);
		void updateShort(java.lang.String arg0, short arg1);
		void updateString(int arg0, java.lang.String arg1);
		void updateString(java.lang.String arg0, java.lang.String arg1);
		bool wasNull();
		global::java.math.BigDecimal getBigDecimal(int arg0, int arg1);
		global::java.math.BigDecimal getBigDecimal(int arg0);
		global::java.math.BigDecimal getBigDecimal(java.lang.String arg0);
		global::java.math.BigDecimal getBigDecimal(java.lang.String arg0, int arg1);
		global::java.io.InputStream getAsciiStream(java.lang.String arg0);
		global::java.io.InputStream getAsciiStream(int arg0);
		global::java.io.InputStream getUnicodeStream(java.lang.String arg0);
		global::java.io.InputStream getUnicodeStream(int arg0);
		global::java.io.InputStream getBinaryStream(int arg0);
		global::java.io.InputStream getBinaryStream(java.lang.String arg0);
		global::java.sql.SQLWarning getWarnings();
		void clearWarnings();
		global::java.lang.String getCursorName();
		global::java.sql.ResultSetMetaData getMetaData();
		int findColumn(java.lang.String arg0);
		global::java.io.Reader getCharacterStream(java.lang.String arg0);
		global::java.io.Reader getCharacterStream(int arg0);
		void beforeFirst();
		void afterLast();
		int getRow();
		bool absolute(int arg0);
		bool relative(int arg0);
		void setFetchDirection(int arg0);
		int getFetchDirection();
		void setFetchSize(int arg0);
		int getFetchSize();
		int getConcurrency();
		bool rowUpdated();
		bool rowInserted();
		bool rowDeleted();
		void updateNull(java.lang.String arg0);
		void updateNull(int arg0);
		void updateBoolean(int arg0, bool arg1);
		void updateBoolean(java.lang.String arg0, bool arg1);
		void updateByte(int arg0, byte arg1);
		void updateByte(java.lang.String arg0, byte arg1);
		void updateBigDecimal(int arg0, java.math.BigDecimal arg1);
		void updateBigDecimal(java.lang.String arg0, java.math.BigDecimal arg1);
		void updateTimestamp(java.lang.String arg0, java.sql.Timestamp arg1);
		void updateTimestamp(int arg0, java.sql.Timestamp arg1);
		void updateAsciiStream(java.lang.String arg0, java.io.InputStream arg1);
		void updateAsciiStream(java.lang.String arg0, java.io.InputStream arg1, long arg2);
		void updateAsciiStream(int arg0, java.io.InputStream arg1, long arg2);
		void updateAsciiStream(java.lang.String arg0, java.io.InputStream arg1, int arg2);
		void updateAsciiStream(int arg0, java.io.InputStream arg1);
		void updateAsciiStream(int arg0, java.io.InputStream arg1, int arg2);
		void updateBinaryStream(java.lang.String arg0, java.io.InputStream arg1, int arg2);
		void updateBinaryStream(int arg0, java.io.InputStream arg1, int arg2);
		void updateBinaryStream(int arg0, java.io.InputStream arg1, long arg2);
		void updateBinaryStream(java.lang.String arg0, java.io.InputStream arg1, long arg2);
		void updateBinaryStream(int arg0, java.io.InputStream arg1);
		void updateBinaryStream(java.lang.String arg0, java.io.InputStream arg1);
		void updateCharacterStream(java.lang.String arg0, java.io.Reader arg1, int arg2);
		void updateCharacterStream(int arg0, java.io.Reader arg1, int arg2);
		void updateCharacterStream(int arg0, java.io.Reader arg1, long arg2);
		void updateCharacterStream(java.lang.String arg0, java.io.Reader arg1, long arg2);
		void updateCharacterStream(int arg0, java.io.Reader arg1);
		void updateCharacterStream(java.lang.String arg0, java.io.Reader arg1);
		void updateObject(java.lang.String arg0, java.lang.Object arg1);
		void updateObject(int arg0, java.lang.Object arg1);
		void updateObject(int arg0, java.lang.Object arg1, int arg2);
		void updateObject(java.lang.String arg0, java.lang.Object arg1, int arg2);
		void insertRow();
		void updateRow();
		void refreshRow();
		void cancelRowUpdates();
		void moveToInsertRow();
		void moveToCurrentRow();
		global::java.sql.Statement getStatement();
		global::java.sql.Clob getClob(java.lang.String arg0);
		global::java.sql.Clob getClob(int arg0);
		void updateRef(java.lang.String arg0, java.sql.Ref arg1);
		void updateRef(int arg0, java.sql.Ref arg1);
		void updateClob(java.lang.String arg0, java.sql.Clob arg1);
		void updateClob(int arg0, java.io.Reader arg1);
		void updateClob(java.lang.String arg0, java.io.Reader arg1);
		void updateClob(int arg0, java.io.Reader arg1, long arg2);
		void updateClob(java.lang.String arg0, java.io.Reader arg1, long arg2);
		void updateClob(int arg0, java.sql.Clob arg1);
		void updateArray(int arg0, java.sql.Array arg1);
		void updateArray(java.lang.String arg0, java.sql.Array arg1);
		int getHoldability();
		void updateNString(java.lang.String arg0, java.lang.String arg1);
		void updateNString(int arg0, java.lang.String arg1);
		void updateNClob(int arg0, java.io.Reader arg1);
		void updateNClob(int arg0, java.io.Reader arg1, long arg2);
		void updateNClob(java.lang.String arg0, java.io.Reader arg1, long arg2);
		void updateNClob(java.lang.String arg0, java.io.Reader arg1);
		global::java.lang.String getNString(java.lang.String arg0);
		global::java.lang.String getNString(int arg0);
		global::java.io.Reader getNCharacterStream(int arg0);
		global::java.io.Reader getNCharacterStream(java.lang.String arg0);
		void updateNCharacterStream(int arg0, java.io.Reader arg1);
		void updateNCharacterStream(java.lang.String arg0, java.io.Reader arg1, long arg2);
		void updateNCharacterStream(int arg0, java.io.Reader arg1, long arg2);
		void updateNCharacterStream(java.lang.String arg0, java.io.Reader arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.sql.ResultSet))]
	public sealed partial class ResultSet_ : java.lang.Object, ResultSet
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ResultSet_()
		{
			InitJNI();
		}
		internal ResultSet_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getObject18957;
		 global::java.lang.Object java.sql.ResultSet.getObject(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getObject18957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getObject18957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getObject18958;
		 global::java.lang.Object java.sql.ResultSet.getObject(int arg0, java.util.Map arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getObject18958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getObject18958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getObject18959;
		 global::java.lang.Object java.sql.ResultSet.getObject(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getObject18959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getObject18959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getObject18960;
		 global::java.lang.Object java.sql.ResultSet.getObject(java.lang.String arg0, java.util.Map arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getObject18960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getObject18960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getBoolean18961;
		 bool java.sql.ResultSet.getBoolean(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_._getBoolean18961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getBoolean18961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBoolean18962;
		 bool java.sql.ResultSet.getBoolean(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_._getBoolean18962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getBoolean18962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getByte18963;
		 byte java.sql.ResultSet.getByte(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.sql.ResultSet_._getByte18963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getByte18963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getByte18964;
		 byte java.sql.ResultSet.getByte(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.sql.ResultSet_._getByte18964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getByte18964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getShort18965;
		 short java.sql.ResultSet.getShort(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.sql.ResultSet_._getShort18965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getShort18965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getShort18966;
		 short java.sql.ResultSet.getShort(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.sql.ResultSet_._getShort18966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getShort18966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInt18967;
		 int java.sql.ResultSet.getInt(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.ResultSet_._getInt18967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getInt18967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInt18968;
		 int java.sql.ResultSet.getInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.ResultSet_._getInt18968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getInt18968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong18969;
		 long java.sql.ResultSet.getLong(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.sql.ResultSet_._getLong18969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getLong18969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong18970;
		 long java.sql.ResultSet.getLong(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.sql.ResultSet_._getLong18970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getLong18970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat18971;
		 float java.sql.ResultSet.getFloat(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.sql.ResultSet_._getFloat18971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getFloat18971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat18972;
		 float java.sql.ResultSet.getFloat(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.sql.ResultSet_._getFloat18972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getFloat18972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble18973;
		 double java.sql.ResultSet.getDouble(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.sql.ResultSet_._getDouble18973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getDouble18973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble18974;
		 double java.sql.ResultSet.getDouble(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.sql.ResultSet_._getDouble18974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getDouble18974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBytes18975;
		 byte[] java.sql.ResultSet.getBytes(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getBytes18975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getBytes18975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getBytes18976;
		 byte[] java.sql.ResultSet.getBytes(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getBytes18976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getBytes18976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getArray18977;
		 global::java.sql.Array java.sql.ResultSet.getArray(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Array>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getArray18977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Array;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Array>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getArray18977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Array;
		}
		internal static global::MonoJavaBridge.MethodId _getArray18978;
		 global::java.sql.Array java.sql.ResultSet.getArray(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Array>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getArray18978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Array;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Array>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getArray18978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Array;
		}
		internal static global::MonoJavaBridge.MethodId _next18979;
		 bool java.sql.ResultSet.next() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_._next18979);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._next18979);
		}
		internal static global::MonoJavaBridge.MethodId _getURL18980;
		 global::java.net.URL java.sql.ResultSet.getURL(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getURL18980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getURL18980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _getURL18981;
		 global::java.net.URL java.sql.ResultSet.getURL(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getURL18981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getURL18981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _close18982;
		 void java.sql.ResultSet.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._close18982);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._close18982);
		}
		internal static global::MonoJavaBridge.MethodId _getType18983;
		 int java.sql.ResultSet.getType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.ResultSet_._getType18983);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getType18983);
		}
		internal static global::MonoJavaBridge.MethodId _previous18984;
		 bool java.sql.ResultSet.previous() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_._previous18984);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._previous18984);
		}
		internal static global::MonoJavaBridge.MethodId _getRef18985;
		 global::java.sql.Ref java.sql.ResultSet.getRef(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Ref>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getRef18985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Ref;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Ref>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getRef18985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Ref;
		}
		internal static global::MonoJavaBridge.MethodId _getRef18986;
		 global::java.sql.Ref java.sql.ResultSet.getRef(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Ref>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getRef18986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Ref;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Ref>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getRef18986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Ref;
		}
		internal static global::MonoJavaBridge.MethodId _getString18987;
		 global::java.lang.String java.sql.ResultSet.getString(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getString18987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getString18987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getString18988;
		 global::java.lang.String java.sql.ResultSet.getString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getString18988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getString18988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isFirst18989;
		 bool java.sql.ResultSet.isFirst() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_._isFirst18989);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._isFirst18989);
		}
		internal static global::MonoJavaBridge.MethodId _getTime18990;
		 global::java.sql.Time java.sql.ResultSet.getTime(java.lang.String arg0, java.util.Calendar arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getTime18990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Time;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getTime18990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Time;
		}
		internal static global::MonoJavaBridge.MethodId _getTime18991;
		 global::java.sql.Time java.sql.ResultSet.getTime(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getTime18991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Time;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getTime18991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Time;
		}
		internal static global::MonoJavaBridge.MethodId _getTime18992;
		 global::java.sql.Time java.sql.ResultSet.getTime(int arg0, java.util.Calendar arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getTime18992, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Time;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getTime18992, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Time;
		}
		internal static global::MonoJavaBridge.MethodId _getTime18993;
		 global::java.sql.Time java.sql.ResultSet.getTime(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getTime18993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Time;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getTime18993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Time;
		}
		internal static global::MonoJavaBridge.MethodId _getDate18994;
		 global::java.sql.Date java.sql.ResultSet.getDate(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getDate18994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getDate18994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getDate18995;
		 global::java.sql.Date java.sql.ResultSet.getDate(java.lang.String arg0, java.util.Calendar arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getDate18995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getDate18995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getDate18996;
		 global::java.sql.Date java.sql.ResultSet.getDate(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getDate18996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getDate18996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getDate18997;
		 global::java.sql.Date java.sql.ResultSet.getDate(int arg0, java.util.Calendar arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getDate18997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getDate18997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Date;
		}
		internal static global::MonoJavaBridge.MethodId _isClosed18998;
		 bool java.sql.ResultSet.isClosed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_._isClosed18998);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._isClosed18998);
		}
		internal static global::MonoJavaBridge.MethodId _getTimestamp18999;
		 global::java.sql.Timestamp java.sql.ResultSet.getTimestamp(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getTimestamp18999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Timestamp;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getTimestamp18999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Timestamp;
		}
		internal static global::MonoJavaBridge.MethodId _getTimestamp19000;
		 global::java.sql.Timestamp java.sql.ResultSet.getTimestamp(int arg0, java.util.Calendar arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getTimestamp19000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Timestamp;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getTimestamp19000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Timestamp;
		}
		internal static global::MonoJavaBridge.MethodId _getTimestamp19001;
		 global::java.sql.Timestamp java.sql.ResultSet.getTimestamp(java.lang.String arg0, java.util.Calendar arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getTimestamp19001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Timestamp;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getTimestamp19001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Timestamp;
		}
		internal static global::MonoJavaBridge.MethodId _getTimestamp19002;
		 global::java.sql.Timestamp java.sql.ResultSet.getTimestamp(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getTimestamp19002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Timestamp;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getTimestamp19002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Timestamp;
		}
		internal static global::MonoJavaBridge.MethodId _last19003;
		 bool java.sql.ResultSet.last() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_._last19003);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._last19003);
		}
		internal static global::MonoJavaBridge.MethodId _first19004;
		 bool java.sql.ResultSet.first() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_._first19004);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._first19004);
		}
		internal static global::MonoJavaBridge.MethodId _updateBytes19005;
		 void java.sql.ResultSet.updateBytes(java.lang.String arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateBytes19005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateBytes19005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateBytes19006;
		 void java.sql.ResultSet.updateBytes(int arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateBytes19006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateBytes19006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isLast19007;
		 bool java.sql.ResultSet.isLast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_._isLast19007);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._isLast19007);
		}
		internal static global::MonoJavaBridge.MethodId _isBeforeFirst19008;
		 bool java.sql.ResultSet.isBeforeFirst() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_._isBeforeFirst19008);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._isBeforeFirst19008);
		}
		internal static global::MonoJavaBridge.MethodId _isAfterLast19009;
		 bool java.sql.ResultSet.isAfterLast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_._isAfterLast19009);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._isAfterLast19009);
		}
		internal static global::MonoJavaBridge.MethodId _getBlob19010;
		 global::java.sql.Blob java.sql.ResultSet.getBlob(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Blob>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getBlob19010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Blob;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Blob>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getBlob19010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Blob;
		}
		internal static global::MonoJavaBridge.MethodId _getBlob19011;
		 global::java.sql.Blob java.sql.ResultSet.getBlob(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Blob>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getBlob19011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Blob;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Blob>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getBlob19011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Blob;
		}
		internal static global::MonoJavaBridge.MethodId _updateDate19012;
		 void java.sql.ResultSet.updateDate(int arg0, java.sql.Date arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateDate19012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateDate19012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateDate19013;
		 void java.sql.ResultSet.updateDate(java.lang.String arg0, java.sql.Date arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateDate19013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateDate19013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateTime19014;
		 void java.sql.ResultSet.updateTime(int arg0, java.sql.Time arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateTime19014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateTime19014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateTime19015;
		 void java.sql.ResultSet.updateTime(java.lang.String arg0, java.sql.Time arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateTime19015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateTime19015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _deleteRow19016;
		 void java.sql.ResultSet.deleteRow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._deleteRow19016);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._deleteRow19016);
		}
		internal static global::MonoJavaBridge.MethodId _updateBlob19017;
		 void java.sql.ResultSet.updateBlob(java.lang.String arg0, java.sql.Blob arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateBlob19017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateBlob19017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateBlob19018;
		 void java.sql.ResultSet.updateBlob(java.lang.String arg0, java.io.InputStream arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateBlob19018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateBlob19018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateBlob19019;
		 void java.sql.ResultSet.updateBlob(int arg0, java.io.InputStream arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateBlob19019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateBlob19019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateBlob19020;
		 void java.sql.ResultSet.updateBlob(int arg0, java.io.InputStream arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateBlob19020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateBlob19020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateBlob19021;
		 void java.sql.ResultSet.updateBlob(java.lang.String arg0, java.io.InputStream arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateBlob19021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateBlob19021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateBlob19022;
		 void java.sql.ResultSet.updateBlob(int arg0, java.sql.Blob arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateBlob19022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateBlob19022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateDouble19023;
		 void java.sql.ResultSet.updateDouble(int arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateDouble19023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateDouble19023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateDouble19024;
		 void java.sql.ResultSet.updateDouble(java.lang.String arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateDouble19024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateDouble19024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateFloat19025;
		 void java.sql.ResultSet.updateFloat(java.lang.String arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateFloat19025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateFloat19025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateFloat19026;
		 void java.sql.ResultSet.updateFloat(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateFloat19026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateFloat19026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateInt19027;
		 void java.sql.ResultSet.updateInt(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateInt19027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateInt19027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateInt19028;
		 void java.sql.ResultSet.updateInt(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateInt19028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateInt19028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateLong19029;
		 void java.sql.ResultSet.updateLong(java.lang.String arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateLong19029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateLong19029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateLong19030;
		 void java.sql.ResultSet.updateLong(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateLong19030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateLong19030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateShort19031;
		 void java.sql.ResultSet.updateShort(int arg0, short arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateShort19031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateShort19031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateShort19032;
		 void java.sql.ResultSet.updateShort(java.lang.String arg0, short arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateShort19032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateShort19032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateString19033;
		 void java.sql.ResultSet.updateString(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateString19033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateString19033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateString19034;
		 void java.sql.ResultSet.updateString(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateString19034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateString19034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _wasNull19035;
		 bool java.sql.ResultSet.wasNull() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_._wasNull19035);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._wasNull19035);
		}
		internal static global::MonoJavaBridge.MethodId _getBigDecimal19036;
		 global::java.math.BigDecimal java.sql.ResultSet.getBigDecimal(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getBigDecimal19036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getBigDecimal19036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _getBigDecimal19037;
		 global::java.math.BigDecimal java.sql.ResultSet.getBigDecimal(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getBigDecimal19037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getBigDecimal19037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _getBigDecimal19038;
		 global::java.math.BigDecimal java.sql.ResultSet.getBigDecimal(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getBigDecimal19038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getBigDecimal19038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _getBigDecimal19039;
		 global::java.math.BigDecimal java.sql.ResultSet.getBigDecimal(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getBigDecimal19039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getBigDecimal19039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _getAsciiStream19040;
		 global::java.io.InputStream java.sql.ResultSet.getAsciiStream(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getAsciiStream19040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getAsciiStream19040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getAsciiStream19041;
		 global::java.io.InputStream java.sql.ResultSet.getAsciiStream(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getAsciiStream19041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getAsciiStream19041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getUnicodeStream19042;
		 global::java.io.InputStream java.sql.ResultSet.getUnicodeStream(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getUnicodeStream19042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getUnicodeStream19042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getUnicodeStream19043;
		 global::java.io.InputStream java.sql.ResultSet.getUnicodeStream(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getUnicodeStream19043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getUnicodeStream19043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getBinaryStream19044;
		 global::java.io.InputStream java.sql.ResultSet.getBinaryStream(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getBinaryStream19044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getBinaryStream19044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getBinaryStream19045;
		 global::java.io.InputStream java.sql.ResultSet.getBinaryStream(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getBinaryStream19045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getBinaryStream19045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getWarnings19046;
		 global::java.sql.SQLWarning java.sql.ResultSet.getWarnings() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getWarnings19046)) as java.sql.SQLWarning;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getWarnings19046)) as java.sql.SQLWarning;
		}
		internal static global::MonoJavaBridge.MethodId _clearWarnings19047;
		 void java.sql.ResultSet.clearWarnings() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._clearWarnings19047);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._clearWarnings19047);
		}
		internal static global::MonoJavaBridge.MethodId _getCursorName19048;
		 global::java.lang.String java.sql.ResultSet.getCursorName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getCursorName19048)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getCursorName19048)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getMetaData19049;
		 global::java.sql.ResultSetMetaData java.sql.ResultSet.getMetaData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSetMetaData>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getMetaData19049)) as java.sql.ResultSetMetaData;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSetMetaData>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getMetaData19049)) as java.sql.ResultSetMetaData;
		}
		internal static global::MonoJavaBridge.MethodId _findColumn19050;
		 int java.sql.ResultSet.findColumn(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.ResultSet_._findColumn19050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._findColumn19050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCharacterStream19051;
		 global::java.io.Reader java.sql.ResultSet.getCharacterStream(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getCharacterStream19051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getCharacterStream19051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
		}
		internal static global::MonoJavaBridge.MethodId _getCharacterStream19052;
		 global::java.io.Reader java.sql.ResultSet.getCharacterStream(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getCharacterStream19052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getCharacterStream19052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
		}
		internal static global::MonoJavaBridge.MethodId _beforeFirst19053;
		 void java.sql.ResultSet.beforeFirst() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._beforeFirst19053);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._beforeFirst19053);
		}
		internal static global::MonoJavaBridge.MethodId _afterLast19054;
		 void java.sql.ResultSet.afterLast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._afterLast19054);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._afterLast19054);
		}
		internal static global::MonoJavaBridge.MethodId _getRow19055;
		 int java.sql.ResultSet.getRow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.ResultSet_._getRow19055);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getRow19055);
		}
		internal static global::MonoJavaBridge.MethodId _absolute19056;
		 bool java.sql.ResultSet.absolute(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_._absolute19056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._absolute19056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _relative19057;
		 bool java.sql.ResultSet.relative(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_._relative19057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._relative19057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFetchDirection19058;
		 void java.sql.ResultSet.setFetchDirection(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._setFetchDirection19058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._setFetchDirection19058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFetchDirection19059;
		 int java.sql.ResultSet.getFetchDirection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.ResultSet_._getFetchDirection19059);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getFetchDirection19059);
		}
		internal static global::MonoJavaBridge.MethodId _setFetchSize19060;
		 void java.sql.ResultSet.setFetchSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._setFetchSize19060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._setFetchSize19060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFetchSize19061;
		 int java.sql.ResultSet.getFetchSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.ResultSet_._getFetchSize19061);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getFetchSize19061);
		}
		internal static global::MonoJavaBridge.MethodId _getConcurrency19062;
		 int java.sql.ResultSet.getConcurrency() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.ResultSet_._getConcurrency19062);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getConcurrency19062);
		}
		internal static global::MonoJavaBridge.MethodId _rowUpdated19063;
		 bool java.sql.ResultSet.rowUpdated() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_._rowUpdated19063);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._rowUpdated19063);
		}
		internal static global::MonoJavaBridge.MethodId _rowInserted19064;
		 bool java.sql.ResultSet.rowInserted() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_._rowInserted19064);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._rowInserted19064);
		}
		internal static global::MonoJavaBridge.MethodId _rowDeleted19065;
		 bool java.sql.ResultSet.rowDeleted() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_._rowDeleted19065);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._rowDeleted19065);
		}
		internal static global::MonoJavaBridge.MethodId _updateNull19066;
		 void java.sql.ResultSet.updateNull(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateNull19066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateNull19066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _updateNull19067;
		 void java.sql.ResultSet.updateNull(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateNull19067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateNull19067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _updateBoolean19068;
		 void java.sql.ResultSet.updateBoolean(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateBoolean19068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateBoolean19068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateBoolean19069;
		 void java.sql.ResultSet.updateBoolean(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateBoolean19069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateBoolean19069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateByte19070;
		 void java.sql.ResultSet.updateByte(int arg0, byte arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateByte19070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateByte19070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateByte19071;
		 void java.sql.ResultSet.updateByte(java.lang.String arg0, byte arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateByte19071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateByte19071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateBigDecimal19072;
		 void java.sql.ResultSet.updateBigDecimal(int arg0, java.math.BigDecimal arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateBigDecimal19072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateBigDecimal19072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateBigDecimal19073;
		 void java.sql.ResultSet.updateBigDecimal(java.lang.String arg0, java.math.BigDecimal arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateBigDecimal19073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateBigDecimal19073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateTimestamp19074;
		 void java.sql.ResultSet.updateTimestamp(java.lang.String arg0, java.sql.Timestamp arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateTimestamp19074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateTimestamp19074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateTimestamp19075;
		 void java.sql.ResultSet.updateTimestamp(int arg0, java.sql.Timestamp arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateTimestamp19075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateTimestamp19075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateAsciiStream19076;
		 void java.sql.ResultSet.updateAsciiStream(java.lang.String arg0, java.io.InputStream arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateAsciiStream19076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateAsciiStream19076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateAsciiStream19077;
		 void java.sql.ResultSet.updateAsciiStream(java.lang.String arg0, java.io.InputStream arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateAsciiStream19077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateAsciiStream19077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateAsciiStream19078;
		 void java.sql.ResultSet.updateAsciiStream(int arg0, java.io.InputStream arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateAsciiStream19078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateAsciiStream19078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateAsciiStream19079;
		 void java.sql.ResultSet.updateAsciiStream(java.lang.String arg0, java.io.InputStream arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateAsciiStream19079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateAsciiStream19079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateAsciiStream19080;
		 void java.sql.ResultSet.updateAsciiStream(int arg0, java.io.InputStream arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateAsciiStream19080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateAsciiStream19080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateAsciiStream19081;
		 void java.sql.ResultSet.updateAsciiStream(int arg0, java.io.InputStream arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateAsciiStream19081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateAsciiStream19081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateBinaryStream19082;
		 void java.sql.ResultSet.updateBinaryStream(java.lang.String arg0, java.io.InputStream arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateBinaryStream19082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateBinaryStream19082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateBinaryStream19083;
		 void java.sql.ResultSet.updateBinaryStream(int arg0, java.io.InputStream arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateBinaryStream19083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateBinaryStream19083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateBinaryStream19084;
		 void java.sql.ResultSet.updateBinaryStream(int arg0, java.io.InputStream arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateBinaryStream19084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateBinaryStream19084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateBinaryStream19085;
		 void java.sql.ResultSet.updateBinaryStream(java.lang.String arg0, java.io.InputStream arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateBinaryStream19085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateBinaryStream19085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateBinaryStream19086;
		 void java.sql.ResultSet.updateBinaryStream(int arg0, java.io.InputStream arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateBinaryStream19086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateBinaryStream19086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateBinaryStream19087;
		 void java.sql.ResultSet.updateBinaryStream(java.lang.String arg0, java.io.InputStream arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateBinaryStream19087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateBinaryStream19087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateCharacterStream19088;
		 void java.sql.ResultSet.updateCharacterStream(java.lang.String arg0, java.io.Reader arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateCharacterStream19088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateCharacterStream19088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateCharacterStream19089;
		 void java.sql.ResultSet.updateCharacterStream(int arg0, java.io.Reader arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateCharacterStream19089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateCharacterStream19089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateCharacterStream19090;
		 void java.sql.ResultSet.updateCharacterStream(int arg0, java.io.Reader arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateCharacterStream19090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateCharacterStream19090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateCharacterStream19091;
		 void java.sql.ResultSet.updateCharacterStream(java.lang.String arg0, java.io.Reader arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateCharacterStream19091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateCharacterStream19091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateCharacterStream19092;
		 void java.sql.ResultSet.updateCharacterStream(int arg0, java.io.Reader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateCharacterStream19092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateCharacterStream19092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateCharacterStream19093;
		 void java.sql.ResultSet.updateCharacterStream(java.lang.String arg0, java.io.Reader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateCharacterStream19093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateCharacterStream19093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateObject19094;
		 void java.sql.ResultSet.updateObject(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateObject19094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateObject19094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateObject19095;
		 void java.sql.ResultSet.updateObject(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateObject19095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateObject19095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateObject19096;
		 void java.sql.ResultSet.updateObject(int arg0, java.lang.Object arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateObject19096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateObject19096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateObject19097;
		 void java.sql.ResultSet.updateObject(java.lang.String arg0, java.lang.Object arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateObject19097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateObject19097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _insertRow19098;
		 void java.sql.ResultSet.insertRow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._insertRow19098);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._insertRow19098);
		}
		internal static global::MonoJavaBridge.MethodId _updateRow19099;
		 void java.sql.ResultSet.updateRow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateRow19099);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateRow19099);
		}
		internal static global::MonoJavaBridge.MethodId _refreshRow19100;
		 void java.sql.ResultSet.refreshRow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._refreshRow19100);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._refreshRow19100);
		}
		internal static global::MonoJavaBridge.MethodId _cancelRowUpdates19101;
		 void java.sql.ResultSet.cancelRowUpdates() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._cancelRowUpdates19101);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._cancelRowUpdates19101);
		}
		internal static global::MonoJavaBridge.MethodId _moveToInsertRow19102;
		 void java.sql.ResultSet.moveToInsertRow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._moveToInsertRow19102);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._moveToInsertRow19102);
		}
		internal static global::MonoJavaBridge.MethodId _moveToCurrentRow19103;
		 void java.sql.ResultSet.moveToCurrentRow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._moveToCurrentRow19103);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._moveToCurrentRow19103);
		}
		internal static global::MonoJavaBridge.MethodId _getStatement19104;
		 global::java.sql.Statement java.sql.ResultSet.getStatement() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Statement>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getStatement19104)) as java.sql.Statement;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Statement>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getStatement19104)) as java.sql.Statement;
		}
		internal static global::MonoJavaBridge.MethodId _getClob19105;
		 global::java.sql.Clob java.sql.ResultSet.getClob(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Clob>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getClob19105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Clob;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Clob>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getClob19105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Clob;
		}
		internal static global::MonoJavaBridge.MethodId _getClob19106;
		 global::java.sql.Clob java.sql.ResultSet.getClob(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Clob>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getClob19106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Clob;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Clob>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getClob19106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Clob;
		}
		internal static global::MonoJavaBridge.MethodId _updateRef19107;
		 void java.sql.ResultSet.updateRef(java.lang.String arg0, java.sql.Ref arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateRef19107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateRef19107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateRef19108;
		 void java.sql.ResultSet.updateRef(int arg0, java.sql.Ref arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateRef19108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateRef19108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateClob19109;
		 void java.sql.ResultSet.updateClob(java.lang.String arg0, java.sql.Clob arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateClob19109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateClob19109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateClob19110;
		 void java.sql.ResultSet.updateClob(int arg0, java.io.Reader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateClob19110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateClob19110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateClob19111;
		 void java.sql.ResultSet.updateClob(java.lang.String arg0, java.io.Reader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateClob19111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateClob19111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateClob19112;
		 void java.sql.ResultSet.updateClob(int arg0, java.io.Reader arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateClob19112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateClob19112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateClob19113;
		 void java.sql.ResultSet.updateClob(java.lang.String arg0, java.io.Reader arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateClob19113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateClob19113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateClob19114;
		 void java.sql.ResultSet.updateClob(int arg0, java.sql.Clob arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateClob19114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateClob19114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateArray19115;
		 void java.sql.ResultSet.updateArray(int arg0, java.sql.Array arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateArray19115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateArray19115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateArray19116;
		 void java.sql.ResultSet.updateArray(java.lang.String arg0, java.sql.Array arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateArray19116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateArray19116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getHoldability19117;
		 int java.sql.ResultSet.getHoldability() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.ResultSet_._getHoldability19117);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getHoldability19117);
		}
		internal static global::MonoJavaBridge.MethodId _updateNString19118;
		 void java.sql.ResultSet.updateNString(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateNString19118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateNString19118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateNString19119;
		 void java.sql.ResultSet.updateNString(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateNString19119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateNString19119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateNClob19120;
		 void java.sql.ResultSet.updateNClob(int arg0, java.io.Reader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateNClob19120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateNClob19120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateNClob19121;
		 void java.sql.ResultSet.updateNClob(int arg0, java.io.Reader arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateNClob19121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateNClob19121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateNClob19122;
		 void java.sql.ResultSet.updateNClob(java.lang.String arg0, java.io.Reader arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateNClob19122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateNClob19122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateNClob19123;
		 void java.sql.ResultSet.updateNClob(java.lang.String arg0, java.io.Reader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateNClob19123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateNClob19123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getNString19124;
		 global::java.lang.String java.sql.ResultSet.getNString(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getNString19124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getNString19124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNString19125;
		 global::java.lang.String java.sql.ResultSet.getNString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getNString19125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getNString19125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNCharacterStream19126;
		 global::java.io.Reader java.sql.ResultSet.getNCharacterStream(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getNCharacterStream19126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getNCharacterStream19126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
		}
		internal static global::MonoJavaBridge.MethodId _getNCharacterStream19127;
		 global::java.io.Reader java.sql.ResultSet.getNCharacterStream(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getNCharacterStream19127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._getNCharacterStream19127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
		}
		internal static global::MonoJavaBridge.MethodId _updateNCharacterStream19128;
		 void java.sql.ResultSet.updateNCharacterStream(int arg0, java.io.Reader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateNCharacterStream19128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateNCharacterStream19128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateNCharacterStream19129;
		 void java.sql.ResultSet.updateNCharacterStream(java.lang.String arg0, java.io.Reader arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateNCharacterStream19129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateNCharacterStream19129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateNCharacterStream19130;
		 void java.sql.ResultSet.updateNCharacterStream(int arg0, java.io.Reader arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateNCharacterStream19130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateNCharacterStream19130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateNCharacterStream19131;
		 void java.sql.ResultSet.updateNCharacterStream(java.lang.String arg0, java.io.Reader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateNCharacterStream19131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.ResultSet_.staticClass, global::java.sql.ResultSet_._updateNCharacterStream19131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.ResultSet_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/ResultSet"));
			global::java.sql.ResultSet_._getObject18957 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getObject", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::java.sql.ResultSet_._getObject18958 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getObject", "(ILjava/util/Map;)Ljava/lang/Object;");
			global::java.sql.ResultSet_._getObject18959 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getObject", "(I)Ljava/lang/Object;");
			global::java.sql.ResultSet_._getObject18960 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getObject", "(Ljava/lang/String;Ljava/util/Map;)Ljava/lang/Object;");
			global::java.sql.ResultSet_._getBoolean18961 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getBoolean", "(Ljava/lang/String;)Z");
			global::java.sql.ResultSet_._getBoolean18962 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getBoolean", "(I)Z");
			global::java.sql.ResultSet_._getByte18963 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getByte", "(Ljava/lang/String;)B");
			global::java.sql.ResultSet_._getByte18964 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getByte", "(I)B");
			global::java.sql.ResultSet_._getShort18965 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getShort", "(I)S");
			global::java.sql.ResultSet_._getShort18966 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getShort", "(Ljava/lang/String;)S");
			global::java.sql.ResultSet_._getInt18967 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getInt", "(Ljava/lang/String;)I");
			global::java.sql.ResultSet_._getInt18968 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getInt", "(I)I");
			global::java.sql.ResultSet_._getLong18969 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getLong", "(Ljava/lang/String;)J");
			global::java.sql.ResultSet_._getLong18970 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getLong", "(I)J");
			global::java.sql.ResultSet_._getFloat18971 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getFloat", "(Ljava/lang/String;)F");
			global::java.sql.ResultSet_._getFloat18972 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getFloat", "(I)F");
			global::java.sql.ResultSet_._getDouble18973 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getDouble", "(I)D");
			global::java.sql.ResultSet_._getDouble18974 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getDouble", "(Ljava/lang/String;)D");
			global::java.sql.ResultSet_._getBytes18975 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getBytes", "(Ljava/lang/String;)[B");
			global::java.sql.ResultSet_._getBytes18976 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getBytes", "(I)[B");
			global::java.sql.ResultSet_._getArray18977 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getArray", "(Ljava/lang/String;)Ljava/sql/Array;");
			global::java.sql.ResultSet_._getArray18978 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getArray", "(I)Ljava/sql/Array;");
			global::java.sql.ResultSet_._next18979 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "next", "()Z");
			global::java.sql.ResultSet_._getURL18980 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getURL", "(Ljava/lang/String;)Ljava/net/URL;");
			global::java.sql.ResultSet_._getURL18981 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getURL", "(I)Ljava/net/URL;");
			global::java.sql.ResultSet_._close18982 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "close", "()V");
			global::java.sql.ResultSet_._getType18983 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getType", "()I");
			global::java.sql.ResultSet_._previous18984 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "previous", "()Z");
			global::java.sql.ResultSet_._getRef18985 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getRef", "(I)Ljava/sql/Ref;");
			global::java.sql.ResultSet_._getRef18986 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getRef", "(Ljava/lang/String;)Ljava/sql/Ref;");
			global::java.sql.ResultSet_._getString18987 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getString", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.sql.ResultSet_._getString18988 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getString", "(I)Ljava/lang/String;");
			global::java.sql.ResultSet_._isFirst18989 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "isFirst", "()Z");
			global::java.sql.ResultSet_._getTime18990 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getTime", "(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Time;");
			global::java.sql.ResultSet_._getTime18991 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getTime", "(Ljava/lang/String;)Ljava/sql/Time;");
			global::java.sql.ResultSet_._getTime18992 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getTime", "(ILjava/util/Calendar;)Ljava/sql/Time;");
			global::java.sql.ResultSet_._getTime18993 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getTime", "(I)Ljava/sql/Time;");
			global::java.sql.ResultSet_._getDate18994 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getDate", "(Ljava/lang/String;)Ljava/sql/Date;");
			global::java.sql.ResultSet_._getDate18995 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getDate", "(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Date;");
			global::java.sql.ResultSet_._getDate18996 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getDate", "(I)Ljava/sql/Date;");
			global::java.sql.ResultSet_._getDate18997 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getDate", "(ILjava/util/Calendar;)Ljava/sql/Date;");
			global::java.sql.ResultSet_._isClosed18998 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "isClosed", "()Z");
			global::java.sql.ResultSet_._getTimestamp18999 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getTimestamp", "(Ljava/lang/String;)Ljava/sql/Timestamp;");
			global::java.sql.ResultSet_._getTimestamp19000 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getTimestamp", "(ILjava/util/Calendar;)Ljava/sql/Timestamp;");
			global::java.sql.ResultSet_._getTimestamp19001 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getTimestamp", "(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Timestamp;");
			global::java.sql.ResultSet_._getTimestamp19002 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getTimestamp", "(I)Ljava/sql/Timestamp;");
			global::java.sql.ResultSet_._last19003 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "last", "()Z");
			global::java.sql.ResultSet_._first19004 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "first", "()Z");
			global::java.sql.ResultSet_._updateBytes19005 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateBytes", "(Ljava/lang/String;[B)V");
			global::java.sql.ResultSet_._updateBytes19006 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateBytes", "(I[B)V");
			global::java.sql.ResultSet_._isLast19007 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "isLast", "()Z");
			global::java.sql.ResultSet_._isBeforeFirst19008 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "isBeforeFirst", "()Z");
			global::java.sql.ResultSet_._isAfterLast19009 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "isAfterLast", "()Z");
			global::java.sql.ResultSet_._getBlob19010 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getBlob", "(Ljava/lang/String;)Ljava/sql/Blob;");
			global::java.sql.ResultSet_._getBlob19011 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getBlob", "(I)Ljava/sql/Blob;");
			global::java.sql.ResultSet_._updateDate19012 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateDate", "(ILjava/sql/Date;)V");
			global::java.sql.ResultSet_._updateDate19013 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateDate", "(Ljava/lang/String;Ljava/sql/Date;)V");
			global::java.sql.ResultSet_._updateTime19014 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateTime", "(ILjava/sql/Time;)V");
			global::java.sql.ResultSet_._updateTime19015 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateTime", "(Ljava/lang/String;Ljava/sql/Time;)V");
			global::java.sql.ResultSet_._deleteRow19016 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "deleteRow", "()V");
			global::java.sql.ResultSet_._updateBlob19017 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateBlob", "(Ljava/lang/String;Ljava/sql/Blob;)V");
			global::java.sql.ResultSet_._updateBlob19018 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateBlob", "(Ljava/lang/String;Ljava/io/InputStream;J)V");
			global::java.sql.ResultSet_._updateBlob19019 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateBlob", "(ILjava/io/InputStream;)V");
			global::java.sql.ResultSet_._updateBlob19020 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateBlob", "(ILjava/io/InputStream;J)V");
			global::java.sql.ResultSet_._updateBlob19021 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateBlob", "(Ljava/lang/String;Ljava/io/InputStream;)V");
			global::java.sql.ResultSet_._updateBlob19022 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateBlob", "(ILjava/sql/Blob;)V");
			global::java.sql.ResultSet_._updateDouble19023 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateDouble", "(ID)V");
			global::java.sql.ResultSet_._updateDouble19024 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateDouble", "(Ljava/lang/String;D)V");
			global::java.sql.ResultSet_._updateFloat19025 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateFloat", "(Ljava/lang/String;F)V");
			global::java.sql.ResultSet_._updateFloat19026 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateFloat", "(IF)V");
			global::java.sql.ResultSet_._updateInt19027 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateInt", "(Ljava/lang/String;I)V");
			global::java.sql.ResultSet_._updateInt19028 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateInt", "(II)V");
			global::java.sql.ResultSet_._updateLong19029 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateLong", "(Ljava/lang/String;J)V");
			global::java.sql.ResultSet_._updateLong19030 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateLong", "(IJ)V");
			global::java.sql.ResultSet_._updateShort19031 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateShort", "(IS)V");
			global::java.sql.ResultSet_._updateShort19032 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateShort", "(Ljava/lang/String;S)V");
			global::java.sql.ResultSet_._updateString19033 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateString", "(ILjava/lang/String;)V");
			global::java.sql.ResultSet_._updateString19034 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateString", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.sql.ResultSet_._wasNull19035 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "wasNull", "()Z");
			global::java.sql.ResultSet_._getBigDecimal19036 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getBigDecimal", "(II)Ljava/math/BigDecimal;");
			global::java.sql.ResultSet_._getBigDecimal19037 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getBigDecimal", "(I)Ljava/math/BigDecimal;");
			global::java.sql.ResultSet_._getBigDecimal19038 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getBigDecimal", "(Ljava/lang/String;)Ljava/math/BigDecimal;");
			global::java.sql.ResultSet_._getBigDecimal19039 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getBigDecimal", "(Ljava/lang/String;I)Ljava/math/BigDecimal;");
			global::java.sql.ResultSet_._getAsciiStream19040 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getAsciiStream", "(Ljava/lang/String;)Ljava/io/InputStream;");
			global::java.sql.ResultSet_._getAsciiStream19041 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getAsciiStream", "(I)Ljava/io/InputStream;");
			global::java.sql.ResultSet_._getUnicodeStream19042 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getUnicodeStream", "(Ljava/lang/String;)Ljava/io/InputStream;");
			global::java.sql.ResultSet_._getUnicodeStream19043 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getUnicodeStream", "(I)Ljava/io/InputStream;");
			global::java.sql.ResultSet_._getBinaryStream19044 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getBinaryStream", "(I)Ljava/io/InputStream;");
			global::java.sql.ResultSet_._getBinaryStream19045 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getBinaryStream", "(Ljava/lang/String;)Ljava/io/InputStream;");
			global::java.sql.ResultSet_._getWarnings19046 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getWarnings", "()Ljava/sql/SQLWarning;");
			global::java.sql.ResultSet_._clearWarnings19047 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "clearWarnings", "()V");
			global::java.sql.ResultSet_._getCursorName19048 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getCursorName", "()Ljava/lang/String;");
			global::java.sql.ResultSet_._getMetaData19049 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getMetaData", "()Ljava/sql/ResultSetMetaData;");
			global::java.sql.ResultSet_._findColumn19050 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "findColumn", "(Ljava/lang/String;)I");
			global::java.sql.ResultSet_._getCharacterStream19051 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getCharacterStream", "(Ljava/lang/String;)Ljava/io/Reader;");
			global::java.sql.ResultSet_._getCharacterStream19052 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getCharacterStream", "(I)Ljava/io/Reader;");
			global::java.sql.ResultSet_._beforeFirst19053 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "beforeFirst", "()V");
			global::java.sql.ResultSet_._afterLast19054 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "afterLast", "()V");
			global::java.sql.ResultSet_._getRow19055 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getRow", "()I");
			global::java.sql.ResultSet_._absolute19056 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "absolute", "(I)Z");
			global::java.sql.ResultSet_._relative19057 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "relative", "(I)Z");
			global::java.sql.ResultSet_._setFetchDirection19058 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "setFetchDirection", "(I)V");
			global::java.sql.ResultSet_._getFetchDirection19059 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getFetchDirection", "()I");
			global::java.sql.ResultSet_._setFetchSize19060 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "setFetchSize", "(I)V");
			global::java.sql.ResultSet_._getFetchSize19061 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getFetchSize", "()I");
			global::java.sql.ResultSet_._getConcurrency19062 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getConcurrency", "()I");
			global::java.sql.ResultSet_._rowUpdated19063 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "rowUpdated", "()Z");
			global::java.sql.ResultSet_._rowInserted19064 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "rowInserted", "()Z");
			global::java.sql.ResultSet_._rowDeleted19065 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "rowDeleted", "()Z");
			global::java.sql.ResultSet_._updateNull19066 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateNull", "(Ljava/lang/String;)V");
			global::java.sql.ResultSet_._updateNull19067 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateNull", "(I)V");
			global::java.sql.ResultSet_._updateBoolean19068 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateBoolean", "(IZ)V");
			global::java.sql.ResultSet_._updateBoolean19069 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateBoolean", "(Ljava/lang/String;Z)V");
			global::java.sql.ResultSet_._updateByte19070 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateByte", "(IB)V");
			global::java.sql.ResultSet_._updateByte19071 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateByte", "(Ljava/lang/String;B)V");
			global::java.sql.ResultSet_._updateBigDecimal19072 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateBigDecimal", "(ILjava/math/BigDecimal;)V");
			global::java.sql.ResultSet_._updateBigDecimal19073 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateBigDecimal", "(Ljava/lang/String;Ljava/math/BigDecimal;)V");
			global::java.sql.ResultSet_._updateTimestamp19074 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateTimestamp", "(Ljava/lang/String;Ljava/sql/Timestamp;)V");
			global::java.sql.ResultSet_._updateTimestamp19075 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateTimestamp", "(ILjava/sql/Timestamp;)V");
			global::java.sql.ResultSet_._updateAsciiStream19076 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;)V");
			global::java.sql.ResultSet_._updateAsciiStream19077 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;J)V");
			global::java.sql.ResultSet_._updateAsciiStream19078 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateAsciiStream", "(ILjava/io/InputStream;J)V");
			global::java.sql.ResultSet_._updateAsciiStream19079 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;I)V");
			global::java.sql.ResultSet_._updateAsciiStream19080 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateAsciiStream", "(ILjava/io/InputStream;)V");
			global::java.sql.ResultSet_._updateAsciiStream19081 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateAsciiStream", "(ILjava/io/InputStream;I)V");
			global::java.sql.ResultSet_._updateBinaryStream19082 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;I)V");
			global::java.sql.ResultSet_._updateBinaryStream19083 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateBinaryStream", "(ILjava/io/InputStream;I)V");
			global::java.sql.ResultSet_._updateBinaryStream19084 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateBinaryStream", "(ILjava/io/InputStream;J)V");
			global::java.sql.ResultSet_._updateBinaryStream19085 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;J)V");
			global::java.sql.ResultSet_._updateBinaryStream19086 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateBinaryStream", "(ILjava/io/InputStream;)V");
			global::java.sql.ResultSet_._updateBinaryStream19087 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;)V");
			global::java.sql.ResultSet_._updateCharacterStream19088 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;I)V");
			global::java.sql.ResultSet_._updateCharacterStream19089 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateCharacterStream", "(ILjava/io/Reader;I)V");
			global::java.sql.ResultSet_._updateCharacterStream19090 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateCharacterStream", "(ILjava/io/Reader;J)V");
			global::java.sql.ResultSet_._updateCharacterStream19091 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;J)V");
			global::java.sql.ResultSet_._updateCharacterStream19092 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateCharacterStream", "(ILjava/io/Reader;)V");
			global::java.sql.ResultSet_._updateCharacterStream19093 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;)V");
			global::java.sql.ResultSet_._updateObject19094 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateObject", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::java.sql.ResultSet_._updateObject19095 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateObject", "(ILjava/lang/Object;)V");
			global::java.sql.ResultSet_._updateObject19096 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateObject", "(ILjava/lang/Object;I)V");
			global::java.sql.ResultSet_._updateObject19097 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateObject", "(Ljava/lang/String;Ljava/lang/Object;I)V");
			global::java.sql.ResultSet_._insertRow19098 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "insertRow", "()V");
			global::java.sql.ResultSet_._updateRow19099 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateRow", "()V");
			global::java.sql.ResultSet_._refreshRow19100 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "refreshRow", "()V");
			global::java.sql.ResultSet_._cancelRowUpdates19101 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "cancelRowUpdates", "()V");
			global::java.sql.ResultSet_._moveToInsertRow19102 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "moveToInsertRow", "()V");
			global::java.sql.ResultSet_._moveToCurrentRow19103 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "moveToCurrentRow", "()V");
			global::java.sql.ResultSet_._getStatement19104 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getStatement", "()Ljava/sql/Statement;");
			global::java.sql.ResultSet_._getClob19105 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getClob", "(Ljava/lang/String;)Ljava/sql/Clob;");
			global::java.sql.ResultSet_._getClob19106 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getClob", "(I)Ljava/sql/Clob;");
			global::java.sql.ResultSet_._updateRef19107 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateRef", "(Ljava/lang/String;Ljava/sql/Ref;)V");
			global::java.sql.ResultSet_._updateRef19108 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateRef", "(ILjava/sql/Ref;)V");
			global::java.sql.ResultSet_._updateClob19109 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateClob", "(Ljava/lang/String;Ljava/sql/Clob;)V");
			global::java.sql.ResultSet_._updateClob19110 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateClob", "(ILjava/io/Reader;)V");
			global::java.sql.ResultSet_._updateClob19111 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateClob", "(Ljava/lang/String;Ljava/io/Reader;)V");
			global::java.sql.ResultSet_._updateClob19112 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateClob", "(ILjava/io/Reader;J)V");
			global::java.sql.ResultSet_._updateClob19113 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateClob", "(Ljava/lang/String;Ljava/io/Reader;J)V");
			global::java.sql.ResultSet_._updateClob19114 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateClob", "(ILjava/sql/Clob;)V");
			global::java.sql.ResultSet_._updateArray19115 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateArray", "(ILjava/sql/Array;)V");
			global::java.sql.ResultSet_._updateArray19116 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateArray", "(Ljava/lang/String;Ljava/sql/Array;)V");
			global::java.sql.ResultSet_._getHoldability19117 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getHoldability", "()I");
			global::java.sql.ResultSet_._updateNString19118 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateNString", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.sql.ResultSet_._updateNString19119 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateNString", "(ILjava/lang/String;)V");
			global::java.sql.ResultSet_._updateNClob19120 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateNClob", "(ILjava/io/Reader;)V");
			global::java.sql.ResultSet_._updateNClob19121 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateNClob", "(ILjava/io/Reader;J)V");
			global::java.sql.ResultSet_._updateNClob19122 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateNClob", "(Ljava/lang/String;Ljava/io/Reader;J)V");
			global::java.sql.ResultSet_._updateNClob19123 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateNClob", "(Ljava/lang/String;Ljava/io/Reader;)V");
			global::java.sql.ResultSet_._getNString19124 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getNString", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.sql.ResultSet_._getNString19125 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getNString", "(I)Ljava/lang/String;");
			global::java.sql.ResultSet_._getNCharacterStream19126 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getNCharacterStream", "(I)Ljava/io/Reader;");
			global::java.sql.ResultSet_._getNCharacterStream19127 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getNCharacterStream", "(Ljava/lang/String;)Ljava/io/Reader;");
			global::java.sql.ResultSet_._updateNCharacterStream19128 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateNCharacterStream", "(ILjava/io/Reader;)V");
			global::java.sql.ResultSet_._updateNCharacterStream19129 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateNCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;J)V");
			global::java.sql.ResultSet_._updateNCharacterStream19130 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateNCharacterStream", "(ILjava/io/Reader;J)V");
			global::java.sql.ResultSet_._updateNCharacterStream19131 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateNCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;)V");
		}
	}
}
